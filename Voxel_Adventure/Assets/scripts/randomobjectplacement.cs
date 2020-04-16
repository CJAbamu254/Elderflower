using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class randomobjectplacement : MonoBehaviour
{

    public GameObject[] objectlist;
    public List<GameObject> locationslist = new List<GameObject>();

    //public GameObject activeitems;


    void Start()
    {
        for (int i = 0; i < objectlist.Length; ++i)
        {
            int randomPosition = Random.Range(0, locationslist.Count);

            GameObject objectToBeSpawned = null;
            objectToBeSpawned = Instantiate(objectlist[i], locationslist[randomPosition].transform.position, transform.rotation);
            //objectToBeSpawned.transform.parent = activeitems.transform;

            objectToBeSpawned.transform.parent = locationslist[randomPosition].transform;
            objectToBeSpawned.transform.localScale = new Vector3(1, 1, 1);

            locationslist.Remove(locationslist[randomPosition]);
        }

        for (int i = 0; i < locationslist.Count; i++)
        {
            if (locationslist[i].transform.childCount == 0)
            {
                Destroy(locationslist[i]);
            }
        }
    }
}