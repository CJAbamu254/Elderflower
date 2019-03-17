using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Home : MonoBehaviour
{

    public Button Homebut, Listbut;

    public Image levellist;

    private void Start()
    {
        Homebut.onClick.AddListener(TaskOnClick);
        Listbut.onClick.AddListener(TaskOnClick1);
    }

    void TaskOnClick()
    {
        SceneManager.LoadScene("main menu", LoadSceneMode.Single);
    }

    void TaskOnClick1()
    {
        // transform list image up from below.

        //MainCamera.transform.position = Vector3.Lerp(transform.position, TargetPosition.transform.position, speed * Time.deltaTime);
        //MainCamera.transform.rotation = Quaternion.Lerp(transform.rotation, TargetPosition.transform.rotation, speed * Time.deltaTime);

    }
}
