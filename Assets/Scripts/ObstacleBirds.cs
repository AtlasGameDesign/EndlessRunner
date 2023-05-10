using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleBirds : MonoBehaviour
{
    //object/positie
    public GameObject[] spawnPositions;
    public GameObject[] prefabs;
    
    //timer
    public float spawnTime = 2;
    float timer; 

    void Start()
    {
        
    }

    void Update()
    {
        //+=: alles rechts van het teken wordt bij het linkse gedeelte gevoegd
        timer += Time.deltaTime;

        //timer voor objecten te spawnen
        if(timer >= spawnTime)
        {
            SpawnObstacle();
            timer = 0;
        }
    }

    void SpawnObstacle()
    {
        //berekent een random getal van de lijst (van nul tot het einde van de lijst/array)
        int spawnIndex = Random.Range(0,spawnPositions.Length);
        int prefabIndex = Random.Range(0, prefabs.Length);

        //positie en object zoeken in de array
        Vector3 spawnPos = spawnPositions[spawnIndex].transform.position;
        GameObject toSpawn = prefabs[prefabIndex];

        //Positie, object en rotatie uitvoeren en object op locatie spawnen
        Instantiate(toSpawn, spawnPos, Quaternion.identity);
    }
}
