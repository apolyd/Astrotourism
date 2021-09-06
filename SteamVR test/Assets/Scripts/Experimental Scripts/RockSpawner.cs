using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RockSpawner : MonoBehaviour
{
    public GameObject[] Rocks;
    public int NumberOfRock;
    // Start is called before the first frame update
    public void Start()
    {
        NumberOfRock = 0;
    }
    public void SpawnRock()
    {
        Instantiate(Rocks[NumberOfRock], transform.position, Quaternion.identity);
        NumberOfRock++;
        if(NumberOfRock >= 9)
        {
            NumberOfRock = 0;
        }
    }
}
