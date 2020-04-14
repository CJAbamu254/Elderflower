using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spin : MonoBehaviour
{
    public float speed = 10f;
    public float clickspeed = 45f;

    void Update()
    {
        if (Input.GetMouseButton(0))
        {
            float rotx = Input.GetAxis("Mouse X") * clickspeed * Mathf.Deg2Rad;

            transform.Rotate(Vector3.up, -rotx);
        }

        else
        {
            transform.Rotate(Vector3.up, speed * Time.deltaTime);
        }

        if (Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);

            Vector3 localAngle = transform.localEulerAngles;
            localAngle.y -= clickspeed * touch.deltaPosition.x;
            transform.localEulerAngles = localAngle;
        }
    }
}