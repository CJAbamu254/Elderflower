using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class jump : MonoBehaviour
{

    void Start()
    {
        StartCoroutine(jumping());
    }

    IEnumerator jumping()
    {
        while (true)
        {
            yield return new WaitForSeconds(Random.Range(1.0f, 5.0f));

            transform.position = new Vector3(transform.position.x, 0.5f, transform.position.z);
        }
    }
}
