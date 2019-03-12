using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WS_GM : MonoBehaviour
{
    public MeshRenderer swordToBeMade;
    public GameObject CraftArea;
    public GameObject sword;
    // Only called in Player scripts
    public static bool pickup_1_found = false;
    public static bool pickup_2_found = false;
    public static bool pickup_3_found = false;

    public bool allPickups_found = false;
    public static bool insideCraftingArea = false;
    // Start is called before the first frame update
    void Start()
    {
        sword.SetActive(false);
        // Find the renderer componenet
        swordToBeMade = GameObject.Find("Where To Make Sword").GetComponent<MeshRenderer>();
        // Turn off renderer when game starts
        swordToBeMade.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        // Functions
        ActivateSword();
    }

    void ActivateSword()
    {
        // if all the pickups have been found and the booleans are true
        if(pickup_1_found == true && pickup_2_found == true && pickup_3_found == true)
        {
            // all pick ups have been found
            allPickups_found = true;
        }
        // if all pick ups are found 
        if(allPickups_found)
        {
            // let the crafting area render the area
            swordToBeMade.enabled = true;
            // if the player presses e and is inside the craft area 
            if(Input.GetKeyDown(KeyCode.E) && insideCraftingArea)
            {
                // make local GameObject
                GameObject craftArea = CraftArea;
                // Destroy the craft Area
                Destroy(craftArea);
                // Turn on crafted object
                sword.SetActive(true);
            }

        }
    }
}
