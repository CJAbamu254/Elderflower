using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class levelload : MonoBehaviour
{

    public Button Bed, For, Mal, Zoo, Mus, Tra;

    public GameObject loading;
    private bool load;

    private int levelnum;

    // Start is called before the first frame update
    void Update()
    {
        Bed.onClick.AddListener(TaskOnClick);
        For.onClick.AddListener(TaskOnClick1);
        Mal.onClick.AddListener(TaskOnClick2);
        Zoo.onClick.AddListener(TaskOnClick3);
        Mus.onClick.AddListener(TaskOnClick4);
        Tra.onClick.AddListener(TaskOnClick5);

        //if (load)
        //{
        //    loading.GetComponent<Text>().color = new Color(loading.GetComponent<Text>().color.r, loading.GetComponent<Text>().color.g, loading.GetComponent<Text>().color.b, Mathf.PingPong(Time.time, 1));
        //}
    }

    void TaskOnClick()
    {
        StartCoroutine(GameObject.FindObjectOfType<fadeforui>().FadeAndLoadScene(fadeforui.FadeDirection.In));

        levelnum = 1;

        StartCoroutine(LoadNewScene());
    }

    void TaskOnClick1()
    {
        StartCoroutine(GameObject.FindObjectOfType<fadeforui>().FadeAndLoadScene(fadeforui.FadeDirection.In));

        levelnum = 2;

        StartCoroutine(LoadNewScene());
    }

    void TaskOnClick2()
    {
        StartCoroutine(GameObject.FindObjectOfType<fadeforui>().FadeAndLoadScene(fadeforui.FadeDirection.In));

        levelnum = 3;

        StartCoroutine(LoadNewScene());
    }

    void TaskOnClick3()
    {
        StartCoroutine(GameObject.FindObjectOfType<fadeforui>().FadeAndLoadScene(fadeforui.FadeDirection.In));

        levelnum = 4;

        StartCoroutine(LoadNewScene());
    }

    void TaskOnClick4()
    {
        StartCoroutine(GameObject.FindObjectOfType<fadeforui>().FadeAndLoadScene(fadeforui.FadeDirection.In));

        levelnum = 5;

        StartCoroutine(LoadNewScene());
    }

    void TaskOnClick5()
    {
        StartCoroutine(GameObject.FindObjectOfType<fadeforui>().FadeAndLoadScene(fadeforui.FadeDirection.In));

        levelnum = 6;

        StartCoroutine(LoadNewScene());
    }

    IEnumerator LoadNewScene()
    {
        yield return new WaitForSeconds(3);

        loading.SetActive(true);
        
        //load = true;

        yield return new WaitForSeconds(1);

        SceneManager.LoadScene(levelnum);

        //AsyncOperation async = SceneManager.LoadSceneAsync(levelnum);

        //while (!async.isDone)
        //{
        //    yield return null;
        //}
    }
}
