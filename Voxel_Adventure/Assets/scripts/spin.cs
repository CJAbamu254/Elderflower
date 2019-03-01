using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class spin : MonoBehaviour
{

    public float speed = 10f;
    public float clickspeed = 45f;

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {

        }

        else
        {
           transform.Rotate(Vector3.up, speed * Time.deltaTime);
        }
    }

    private void OnMouseDrag()
    {
        float rotx = Input.GetAxis("Mouse X") * clickspeed * Mathf.Deg2Rad;

        transform.Rotate(Vector3.up, -rotx);
    }

}