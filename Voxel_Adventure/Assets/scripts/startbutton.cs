using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class startbutton : MonoBehaviour
{

    public Button m_YourFirstButton, m_YourSecondButton, m_YourThirdButton, m_YourLastButton;
    public GameObject mainbuttons;
    public GameObject settings;

    public GameObject home;
    void Start()
    {
        //Calls the TaskOnClick/TaskWithParameters/ButtonClicked method when you click the Button
        m_YourFirstButton.onClick.AddListener(startb);
        m_YourSecondButton.onClick.AddListener(exitb);
        m_YourThirdButton.onClick.AddListener(settingb);
        m_YourLastButton.onClick.AddListener(close);


        mainbuttons = gameObject;
    }

    void startb()
    {
        //Output this to console when Button1 is clicked
        home.SetActive(true);
        Destroy(mainbuttons);
    }

    void exitb()
    {
        //Output this to console when the Button2 is clicked
        
         Application.Quit();
    }

    void settingb()
    {
        //Output this to console when the Button3 is clicked
        settings.SetActive(true);
    }

    void close()
    {
        settings.SetActive(false);

    }
}
