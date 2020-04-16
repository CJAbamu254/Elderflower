using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class winscript : MonoBehaviour
{
    public GameObject home, oldhome, oldlist, oldlistbut;

    public GameObject spawnlocations;
    public List<GameObject> locationslist = new List<GameObject>();

    void Update()
    {
        for (int i = 0; i < locationslist.Count; i++)
        {
            if (locationslist[i] == null)
            {
                locationslist.Remove(locationslist[i]);
            }

            if (locationslist[i].transform.childCount == 0)
            {
                Destroy(locationslist[i]);
            }
        }

        if (spawnlocations.transform.childCount == 0)
        {
            home.SetActive(true);
            oldhome.SetActive(false);
            oldlist.SetActive(false);
            oldlistbut.SetActive(false);

        }
    }
}
