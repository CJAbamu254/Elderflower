using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WS_PC_3D_Controller : MonoBehaviour
{
    // how fast the player moves 
    public float speed = 5;
    // how fast the player rotates
    public float rotationSpeed = 10;
    // Where the player moves in the game world
    public Vector3 moveDriection = Vector3.zero;
    // character controller component reference
    private CharacterController CC_PC;
    // Pickup GameObject
    private GameObject pickup_handle;
    // Pickup GameObject
    private GameObject pickup_blade;
    // Pickup GameObject
    private GameObject pickup_gem;
    // GameObject that will be where the player crafts their sword
    private GameObject craft_Area;

    // Start is called before the first frame update
    void Start()
    {
        // Finding the gameObject attached to this gameObject
        CC_PC = GetComponent<CharacterController>();

        // Find all pickup Objects
        pickup_handle = GameObject.Find("PickUp 1");
        pickup_blade = GameObject.Find("Pickup 2");
        pickup_gem = GameObject.Find("Pickup 3");
        craft_Area = GameObject.Find("Where To Make Sword");
    }

    // Update is called once per frame
    void Update()
    {
        // Functions
        PCMove();
        PCRotation();
    }
    void PCMove()
    {
        // Filling the moveDirection Vector with the movement inputs
        moveDriection = new Vector3(0, 0.0f, Input.GetAxis("Vertical"));
        // Player will move in the direction of whatever input they press
        moveDriection = transform.TransformDirection(moveDriection);
        // speed moved on the moveDirection
        moveDriection = moveDriection * speed;
        // Move the player character
        CC_PC.Move(moveDriection * Time.deltaTime);
    }

    void PCRotation()
    {
        // if player press the A key
        if (Input.GetKey(KeyCode.A))
            transform.Rotate(-Vector3.up * rotationSpeed * Time.deltaTime); // player moves left on the Y axis
        // if the player presses D key
        if (Input.GetKey(KeyCode.D))
            transform.Rotate(Vector3.up * rotationSpeed * Time.deltaTime);  // player moves right on the Y axis
    }

    public void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Handle Pickup")
        {
            // make Boolean true in GM
            WS_GM.pickup_1_found = true;
            // Make a seperate local GameObject so you dont destroy the reference
            GameObject pickup1 = pickup_handle;
            // Destroy the local GameObject
            Destroy(pickup1);
        }

        if (other.gameObject.tag == "Blade Pickup")
        {
            // Activate boolean in GM
            WS_GM.pickup_2_found = true;
            // Make local GameObject
            GameObject pickup2 = pickup_blade;
            // Destroy the local GameObject when player walks into it
            Destroy(pickup2);
        }

        if (other.gameObject.tag == "Gem Pickup")
        {
            // Activate boolean in GM
            WS_GM.pickup_3_found = true;
            // Make local GameObject
            GameObject pickup3 = pickup_gem;
            // Destroy the local GameObject when player walks into it
            Destroy(pickup3);
        }
        // if player is inside the trigger MaekSword
        if(other.gameObject.tag == "MakeSword")
        {
            // Set GM boolean true
            WS_GM.insideCraftingArea = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        // if the player exits a trigger tagged MakeSword
        if (other.gameObject.tag == "MakeSword")
        {
            // Make boolean in GM false
            WS_GM.insideCraftingArea = false;
        }
    }
}
