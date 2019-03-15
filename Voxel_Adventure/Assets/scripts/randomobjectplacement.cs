using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class randomobjectplacement : MonoBehaviour
{

    public List<GameObject> objectlist = new List<GameObject>();
    public List<GameObject> locationslist = new List<GameObject>();

    private int objectIndex;
    private int spawnIndex;
    private GameObject obj;

    List<int> randomObjects = new List<int>();
    List<int> randomPositions = new List<int>();

    public GameObject level;


    void Start()
    {
        for (int i = 0; i < 3; ++i)
        {

            int randomObject;
            do
            {
                randomObject = Random.Range(0, objectlist.Count);
            }
            while (randomObjects.Contains(randomObject));
            randomObjects.Add(randomObject);

            int randomPosition;
            do
            {
                randomPosition = Random.Range(0, locationslist.Count);
            }
            while (randomPositions.Contains(randomPosition));
            randomPositions.Add(randomPosition);

            GameObject objectToBeSpawned = null;
            objectToBeSpawned = Instantiate(objectlist[randomObject], locationslist[randomPosition].transform.position, locationslist[randomPosition].transform.rotation);
            objectToBeSpawned.transform.parent = level.transform;
        }
    }

    private void Update()
    {
        if (Input.GetKey("escape"))
        {
            Application.Quit();
        }
    }
}


//code from https://stackoverflow.com/questions/41997818/how-to-instantiate-3-gameobjects-in-3-positions-of-a-list-of-20-random-positions