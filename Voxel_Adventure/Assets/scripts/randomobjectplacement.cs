using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class randomobjectplacement : MonoBehaviour
{

    public GameObject[] objectlist;
    public List<GameObject> locationslist = new List<GameObject>();

    public GameObject level;


    void Start()
    {
        for (int i = 0; i < objectlist.Length; ++i)
        {
            int randomPosition = Random.Range(0, locationslist.Count);

            GameObject objectToBeSpawned = null;
            objectToBeSpawned = Instantiate(objectlist[i], locationslist[randomPosition].transform.position, locationslist[randomPosition].transform.rotation);
            objectToBeSpawned.transform.parent = level.transform;

            locationslist.Remove(locationslist[randomPosition]);
        }

        for (int i = 0; i < locationslist.Count; i++)
        {
            Destroy(locationslist[i]);
        }
    }
}