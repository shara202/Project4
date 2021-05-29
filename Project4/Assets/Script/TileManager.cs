using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TileManager : MonoBehaviour
{
    private List<GameObject> activeTile = new List<GameObject>();
    

    public GameObject[] tilePrefab;
    public float zSpawn = 0;
    public float lengthTile = 32;
    public float tileNumber = 5;
    public Transform playerTransform;
    // Start is called before the first frame update
    void Start()
    {
        for(int i = 0; i < tileNumber; i++)
        {
            if (i == 0)
                SpawnTile(0);
            else
            SpawnTile(Random.Range(0, tilePrefab.Length));
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (playerTransform.position.z-35 > zSpawn - (tileNumber * lengthTile))
        {
            SpawnTile(Random.Range(0, tilePrefab.Length));
            DeleteTiel();
        }
    }
    void SpawnTile(int TileIndex )
    {
        GameObject go=Instantiate(tilePrefab[TileIndex], transform.forward * zSpawn, transform.rotation);
        activeTile.Add(go);
        zSpawn += lengthTile;
    }
    void DeleteTiel()
    {
        Destroy(activeTile[0]);
        activeTile.RemoveAt(0);
    }
}
