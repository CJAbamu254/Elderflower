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

        for (int i = 0; i < Input.touchCount; ++i)
        {
            if (Input.GetTouch(i).phase == TouchPhase.Began)
            {
                float rotx = Input.GetAxis("Mouse X") * clickspeed * Mathf.Deg2Rad;

                transform.Rotate(Vector3.up, -rotx);
            }
        }
    }
}