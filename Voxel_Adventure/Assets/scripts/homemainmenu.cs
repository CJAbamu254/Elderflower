using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class homemainmenu : MonoBehaviour
{

    public Button Homebut;

    // Start is called before the first frame update
    void Start()
    {
        Homebut.onClick.AddListener(TaskOnClick);

    }
    void TaskOnClick()
    {
        SceneManager.LoadScene("main menu", LoadSceneMode.Single);
    }
}
