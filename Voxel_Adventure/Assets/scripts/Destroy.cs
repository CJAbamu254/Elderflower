using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroy : MonoBehaviour
{
    public GameObject DestroyPS;

    public void Start()
    {
        //Fix this!!

        //BroadcastMessage(gameObject.name);
    }

    void OnMouseDown()
    {
        
        Instantiate(DestroyPS, transform.position, DestroyPS.transform.rotation);
        Destroy(gameObject);
    }
}