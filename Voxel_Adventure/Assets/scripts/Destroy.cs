using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroy : MonoBehaviour
{
    public GameObject DestroyPS;

    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            Instantiate(DestroyPS, transform.position, DestroyPS.transform.rotation);
            Destroy(this.gameObject);
        }
    }
}