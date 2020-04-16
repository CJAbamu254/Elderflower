using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroy : MonoBehaviour
{
    public GameObject DestroyPS;
    public bool kill;
    public GameObject otherdestroy;

    void Update()
    {
        if (kill == true)
        {
            GameObject clone = Instantiate(DestroyPS, transform.position, DestroyPS.transform.rotation);
            clone.transform.parent = null;
            Destroy(otherdestroy);
            Destroy(this.gameObject);
        }
    }
}