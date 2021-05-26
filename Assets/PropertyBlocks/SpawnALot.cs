using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnALot : MonoBehaviour
{
    public int count;

    public GameObject prefab;

    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < count; i++)
        {
            Instantiate(prefab, Random.insideUnitSphere * 100, Quaternion.identity);
        }
    }

    // Update is called once per frame
    void Update()
    {
    }
}