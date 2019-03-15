using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyComplete : MonoBehaviour
{

    private void Start()
    {
        Destroy(gameObject, 5f);
    }
}
