using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour
{   
    public GameObject[] animal;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnAnimal", 3.0f, 1.0f);
    }

    // Update is called once per frame
    void Update()
    {
    }

    private void SpawnAnimal()
    {
        int index = Random.Range(0, animal.Length);
        Instantiate(animal[index], new Vector3(0.0f, 0.0f, 20.0f), animal[index].transform.rotation);
    }
}

