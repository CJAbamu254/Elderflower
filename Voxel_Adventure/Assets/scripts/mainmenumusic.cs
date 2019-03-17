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
            if (Bed.Raycast(ray, out hit, 2f))
            {
                main = mainmusic[1];     // bedroom music
                camaudio.clip = main;
                camaudio.Play();

                BEBut.SetActive(true);

                FRBut.SetActive(false);
                MABut.SetActive(false);
                ZOBut.SetActive(false);
                MUBut.SetActive(false);
                TRBut.SetActive(false);
            }

            if (Forest.Raycast(ray, out hit, 2f))
            {
                main = mainmusic[2];        // Forest music
                camaudio.clip = main;
                camaudio.Play();

                FRBut.SetActive(true);

                BEBut.SetActive(false);
                MABut.SetActive(false);
                ZOBut.SetActive(false);
                MUBut.SetActive(false);
                TRBut.SetActive(false);
            }

            if (Mall.Raycast(ray, out hit, 2f))
            {
                main = mainmusic[3];        // mall music
                camaudio.clip = main;
                camaudio.Play();

                MABut.SetActive(true);

                BEBut.SetActive(false);
                FRBut.SetActive(false);
                ZOBut.SetActive(false);
                MUBut.SetActive(false);
                TRBut.SetActive(false);
            }

            if (Zoo.Raycast(ray, out hit, 2f))
            {
                main = mainmusic[4];        // zoo music
                camaudio.clip = main;
                camaudio.Play();

                ZOBut.SetActive(true);

                BEBut.SetActive(false);
                FRBut.SetActive(false);
                MABut.SetActive(false);
                MUBut.SetActive(false);
                TRBut.SetActive(false);
            }

            if (Museum.Raycast(ray, out hit, 2f))
            {
                main = mainmusic[5];        // museum music
                camaudio.clip = main;
                camaudio.Play();

                MUBut.SetActive(true);

                BEBut.SetActive(false);
                FRBut.SetActive(false);
                MABut.SetActive(false);
                ZOBut.SetActive(false);
                TRBut.SetActive(false);
            }

            if (Train.Raycast(ray, out hit, 2f))
            {
                main = mainmusic[6];        // train music
                camaudio.clip = main;
                camaudio.Play();

                TRBut.SetActive(true);

                BEBut.SetActive(false);
                FRBut.SetActive(false);
                MABut.SetActive(false);
                ZOBut.SetActive(false);
                MUBut.SetActive(false);
            }
        }
    }
}
