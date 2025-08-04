using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarSpawner : MonoBehaviour
{

    [SerializeField] GameObject CarPrefab;
    [SerializeField] float spawnTimer;
    [SerializeField] private float spawnTime;

    private void Start()
    {
        spawnTime = spawnTimer;
    }
    private void FixedUpdate()
    {
        if (spawnTime <=0)
        {
            Instantiate(CarPrefab, transform.position, CarPrefab.transform.rotation);
            spawnTime = spawnTimer;
        }
        else
        {
            spawnTime -= Time.deltaTime;
        }
    }
}
