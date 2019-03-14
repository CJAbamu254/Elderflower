using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class goto_location : MonoBehaviour
{
    public Camera MainCamera;
    public Transform TargetPosition;
    private float speed = 0.1f;
    public Transform target;


    private void Update()
    {
        transform.LookAt(target);

        MainCamera.transform.position = Vector3.Lerp(transform.position, TargetPosition.transform.position, speed * Time.deltaTime);
        MainCamera.transform.rotation = Quaternion.Lerp(transform.rotation, TargetPosition.transform.rotation, speed * Time.deltaTime);
    }
}
