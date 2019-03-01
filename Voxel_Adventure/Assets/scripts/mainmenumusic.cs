using System.Collections;
using System.Collections.Generic;
using UnityEngine;

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
            }

            if (Forest.Raycast(ray, out hit, 100.0f))
            {
                main = mainmusic[2];
                camaudio.clip = main;
                camaudio.Play();
            }

            if (Mall.Raycast(ray, out hit, 100.0f))
            {
                main = mainmusic[3];
                camaudio.clip = main;
                camaudio.Play();
            }

            if (Zoo.Raycast(ray, out hit, 100.0f))
            {
                main = mainmusic[4];
                camaudio.clip = main;
                camaudio.Play();
            }

            if (Museum.Raycast(ray, out hit, 100.0f))
            {
                main = mainmusic[5];
                camaudio.clip = main;
                camaudio.Play();
            }

            if (Train.Raycast(ray, out hit, 100.0f))
            {
                main = mainmusic[6];
                camaudio.clip = main;
                camaudio.Play();
            }
        }
    }
}
