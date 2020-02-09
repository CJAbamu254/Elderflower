using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
//using Vuforia;


public class torch_on_off : MonoBehaviour
{
    public Button torch;
    private bool status;

    private void Start()
    {
        torch.onClick.AddListener(on);
    }


    private void on()
    {
        //if (status == false)
        //{
        //    CameraDevice.Instance.SetFlashTorchMode(true);
        //    status = true;
        //    Debug.Log("Light ON");

        //}

        //else
        //{
        //    CameraDevice.Instance.SetFlashTorchMode(true);
        //    status = false;
        //    Debug.Log("Light OFF");

        //}
    }
}
