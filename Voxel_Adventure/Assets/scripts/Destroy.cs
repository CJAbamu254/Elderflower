using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroy : MonoBehaviour
{
    public GameObject DestroyPS;

    void Start()
    {
       SendMessage("objectsleft", 1);
    }

    void OnMouseDown()
    {
        
        Instantiate(DestroyPS, transform.position, DestroyPS.transform.rotation);
        Destroy(gameObject);
    }
}