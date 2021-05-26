using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TileManager : MonoBehaviour
{
    public GameObject[] tilePrefab;
    public float zSpawn = 0;
    public float lengthTile = 32;
    public float tileNumber = 5;
    // Start is called before the first frame update
    void Start()
    {
        for(int i = 0; i < tileNumber; i++)
        {
            SpawnTile(Random.Range(0, tilePrefab.Length));
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void SpawnTile(int TileIndex)
    {
        Instantiate(tilePrefab[TileIndex], transform.forward * zSpawn, transform.rotation);
        zSpawn += lengthTile;
    }
}
