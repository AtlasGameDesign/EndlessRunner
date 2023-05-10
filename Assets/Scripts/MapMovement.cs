using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapMovement : MonoBehaviour
{
    public List<GameObject> mapTiles = new List<GameObject>();
    public GameObject playerObject;

    public GameObject tilePrefab;

    public float tilesize = 12;
    public float despawnDistance = -25;

    PlayerMovement player;

    // Start is called before the first frame update
    void Start()
    {
        player = playerObject.GetComponent<PlayerMovement>();
    }

    // Update is called once per frame
    void Update()
    {
        SpawnAndDespawn();
        MoveTiles();
    }
    
    void MoveTiles()
    {
        //voor 5 stappen (index 0,1,2,3,4 (index nooit groter dan de grootste, altijd -1))
        for (int i = 0; i < mapTiles.Count; i++)
        {
            mapTiles[i].transform.position -= Vector3.forward * 35 * Time.deltaTime;
        }
    }

    void SpawnAndDespawn()
    {
        GameObject toRemove = null;

        foreach (var tile in mapTiles)
        {
            //Als de tile te ver weg is, despawn
            if(tile.transform.position.z < despawnDistance)
            {
                toRemove = tile;
            }
        }

        if(toRemove != null)
        {
            // eerst tile verwijderen uit lijst, dan volledig destroyen/despawnen ingame
            mapTiles.Remove(toRemove);
            Destroy(toRemove);

            Vector3 spawnPosition = mapTiles[mapTiles.Count - 1].transform.position + Vector3.forward * tilesize;
            GameObject newTile = Instantiate(tilePrefab, spawnPosition, Quaternion.identity, transform);
            mapTiles.Add(newTile);
        }
    }
}
