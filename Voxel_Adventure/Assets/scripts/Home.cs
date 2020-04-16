using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Home : MonoBehaviour
{

    public Button Homebut, Listbut;

    public Image levellist;
    public float moveDistance;
    private Vector3 Startpos;
    private Vector3 Targetpos;
    public GameObject srtpos, endpos;
    private float move;
    private float CurrentLerpTime;
    private float LerpTime = 0.5f;
    private float perc;


    private void Start()
    {
        Homebut.onClick.AddListener(TaskOnClick);
        Listbut.onClick.AddListener(TaskOnClick1);

        //startpos = levellist.transform.position;
    }

    void TaskOnClick()
    {
        SceneManager.LoadScene("main menu", LoadSceneMode.Single);
    }

    void TaskOnClick1()
    {
        if (move == 0)
        {
            //Startpos = levellist.GetComponent<Transform>().position;
            //Targetpos = Startpos + Vector3.up * moveDistance;

            Startpos = srtpos.transform.position;
            Targetpos = endpos.transform.position;

            move = 1;
        }

        if (move == 2)
        {
            //Startpos = levellist.GetComponent<Transform>().position;
            //Targetpos = Startpos + Vector3.down * moveDistance;

            Startpos = endpos.transform.position;
            Targetpos = srtpos.transform.position;

            move = 3;
        }
    }

    private void Update()
    {
        if (move == 1)
        {
            CurrentLerpTime += Time.deltaTime;
            if (CurrentLerpTime > LerpTime)
            {
                CurrentLerpTime = LerpTime;
            }
            perc = CurrentLerpTime / LerpTime;
            levellist.transform.position = Vector3.Lerp(Startpos, Targetpos, perc);
            if (perc == 1)
            {
                move = 2;
                CurrentLerpTime = 0f;
            }
        }

        if (move == 3)
        {
            CurrentLerpTime += Time.deltaTime;
            if (CurrentLerpTime > LerpTime)
            {
                CurrentLerpTime = LerpTime;
            }
            perc = CurrentLerpTime / LerpTime;
            levellist.transform.position = Vector3.Lerp(Startpos, Targetpos, perc);
            if (perc == 1)
            {
                move = 0;
                CurrentLerpTime = 0f;
            }
        }
    }
}
