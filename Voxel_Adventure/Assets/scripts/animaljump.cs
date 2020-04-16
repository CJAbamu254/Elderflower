using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class animaljump : MonoBehaviour
{
    public float height = 0.5f;

    void Start()
    {
        StartCoroutine(jumping());
    }

    IEnumerator jumping()
    {
        transform.localPosition = new Vector3(transform.localPosition.x, transform.localPosition.y, transform.localPosition.z * height);

        yield return new WaitForSeconds(Random.Range(1.0f, 5.0f));

        StartCoroutine(jumping());
    }
}
