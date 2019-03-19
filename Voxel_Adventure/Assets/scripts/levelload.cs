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
        SceneManager.LoadScene("Bedroomfixed", LoadSceneMode.Single);
    }

    void TaskOnClick1()
    {
        SceneManager.LoadScene("Forest", LoadSceneMode.Single);

    }

    void TaskOnClick2()
    {
        SceneManager.LoadScene("Shopping", LoadSceneMode.Single);

    }

    void TaskOnClick3()
    {
        SceneManager.LoadScene("Zoo", LoadSceneMode.Single);

    }

    void TaskOnClick4()
    {
        SceneManager.LoadScene("Museum", LoadSceneMode.Single);

    }

    void TaskOnClick5()
    {
        SceneManager.LoadScene("Train Station", LoadSceneMode.Single);

    }
}
