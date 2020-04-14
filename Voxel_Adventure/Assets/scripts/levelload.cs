using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class levelload : MonoBehaviour
{

    public Button Bed, For, Mal, Zoo, Mus, Tra;

    // Start is called before the first frame update
    void Update()
    {
        Bed.onClick.AddListener(TaskOnClick);
        For.onClick.AddListener(TaskOnClick1);
        Mal.onClick.AddListener(TaskOnClick2);
        Zoo.onClick.AddListener(TaskOnClick3);
        Mus.onClick.AddListener(TaskOnClick4);
        Tra.onClick.AddListener(TaskOnClick5);
    }

    void TaskOnClick()
    {
        SceneManager.LoadScene(1, LoadSceneMode.Single);
    }

    void TaskOnClick1()
    {
        SceneManager.LoadScene(2, LoadSceneMode.Single);

    }

    void TaskOnClick2()
    {
        SceneManager.LoadScene(3, LoadSceneMode.Single);

    }

    void TaskOnClick3()
    {
        SceneManager.LoadScene(4, LoadSceneMode.Single);

    }

    void TaskOnClick4()
    {
        SceneManager.LoadScene(5, LoadSceneMode.Single);

    }

    void TaskOnClick5()
    {
        SceneManager.LoadScene(6, LoadSceneMode.Single);

    }
}
