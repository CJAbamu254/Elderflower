using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class mainmenumusic : MonoBehaviour
{
    public AudioClip[] mainmusic;

    private AudioSource camaudio;
    private AudioClip main;

    public Collider Bed;
    public Collider Forest;
    public Collider Mall;
    public Collider Zoo;
    public Collider Museum;
    public Collider Train;

    public GameObject BEBut;
    public GameObject FRBut;
    public GameObject MABut;
    public GameObject ZOBut;
    public GameObject MUBut;
    public GameObject TRBut;


    // Start is called before the first frame update
    void Start()
    {
        camaudio = gameObject.GetComponent<AudioSource>();

        main = mainmusic[0];
        camaudio.clip = main;
        camaudio.Play();
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        { // if left button pressed...
            Ray ray = GetComponent<Camera>().ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;
            if (Bed.Raycast(ray, out hit, 100.0f))
            {
                main = mainmusic[1];
                camaudio.clip = main;
                camaudio.Play();

                BEBut.SetActive(true);
            }

            if (Forest.Raycast(ray, out hit, 100.0f))
            {
                main = mainmusic[2];
                camaudio.clip = main;
                camaudio.Play();

                FRBut.SetActive(true);
            }

            if (Mall.Raycast(ray, out hit, 100.0f))
            {
                main = mainmusic[3];
                camaudio.clip = main;
                camaudio.Play();

                MABut.SetActive(true);
            }

            if (Zoo.Raycast(ray, out hit, 100.0f))
            {
                main = mainmusic[4];
                camaudio.clip = main;
                camaudio.Play();

               ZOBut.SetActive(true);
            }

            if (Museum.Raycast(ray, out hit, 100.0f))
            {
                main = mainmusic[5];
                camaudio.clip = main;
                camaudio.Play();

                MUBut.SetActive(true);
            }

            if (Train.Raycast(ray, out hit, 100.0f))
            {
                main = mainmusic[6];
                camaudio.clip = main;
                camaudio.Play();

                TRBut.SetActive(true);
            }

            else
            {
                BEBut.SetActive(false);
                FRBut.SetActive(false);
                MABut.SetActive(false);
                ZOBut.SetActive(false);
                MUBut.SetActive(false);
                TRBut.SetActive(false);

            }
        }

    }
}
