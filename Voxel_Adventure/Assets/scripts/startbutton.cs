﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class startbutton : MonoBehaviour
{

    public Button m_YourFirstButton, m_YourSecondButton, m_YourThirdButton;
    private GameObject mainbuttons;

    void Start()
    {
        //Calls the TaskOnClick/TaskWithParameters/ButtonClicked method when you click the Button
        m_YourFirstButton.onClick.AddListener(startb);
        m_YourSecondButton.onClick.AddListener(exitb);
        m_YourThirdButton.onClick.AddListener(settingb);

        mainbuttons = gameObject;
    }

    void startb()
    {
        //Output this to console when Button1 is clicked
        Destroy(mainbuttons);
    }

    void exitb()
    {
        //Output this to console when the Button2 is clicked

    }

    void settingb()
    {
        //Output this to console when the Button3 is clicked

    }
}
