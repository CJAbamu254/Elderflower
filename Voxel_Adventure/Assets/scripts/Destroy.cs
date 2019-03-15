using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroy : MonoBehaviour
{
    public GameObject DestroyPS;


    #region NOTICE
    // OnMouseDown is treated as a Raqycast Function but without any effort. Just apply this script to th object you want to destroy
    // Apply a Collider to the object you wish to destroy and apply this script to that obect
    // he object will die when you click the left mouse button
    #endregion
    private void OnMouseDown()
    {
        Instantiate(DestroyPS, transform.position, DestroyPS.transform.rotation);
        Destroy(gameObject);
    }
}

