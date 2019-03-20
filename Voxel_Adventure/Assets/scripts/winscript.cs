using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class winscript : MonoBehaviour
{
    public GameObject home;
    public GameObject oldhome;
    public GameObject oldlist;


    void Update()
    {
        GameObject[] gameObjects;
        gameObjects = GameObject.FindGameObjectsWithTag("objectsleft");

        if (gameObjects.Length == 0)
        {
            home.SetActive(true);
            oldhome.SetActive(false);
            oldlist.SetActive(false);

        }
    }
}
