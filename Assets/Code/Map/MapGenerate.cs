using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapGenerate : MonoBehaviour {
    public Transform tilePrefab;
    public Transform linePrefab;
    public Vector2 mapSize;

    [Range(0,1)]
    public float outlinePercent;

    void Start()
    {
        GenerateMap();
    }

    public void GenerateMap()
    {

        string holderName = "Generated Map";
        if(transform.Find(holderName))
        {
            DestroyImmediate(transform.Find(holderName).gameObject);
        }

        Transform mapHolder = new GameObject(holderName).transform;
        mapHolder.parent = transform;

        for (int x = 0; x < mapSize.x; x++)
        {
            for (int y = 0; y < mapSize.y; y++)
            {
                if(x == 0 && y == 4)
                {

                }
                else if(x == 15 && y == 4){

                }
                else
                {
                    Vector3 tilePosition = new Vector3(-mapSize.x / 2 + x, 0, -mapSize.y / 2 + 0.5f + y);
                    Transform newTile = Instantiate(tilePrefab, tilePosition, Quaternion.Euler(Vector3.right * 90)) as Transform;
                    newTile.localScale = Vector3.one * (1 - outlinePercent);
                    newTile.parent = mapHolder;

                    Vector3 linePosition = new Vector3(-mapSize.x / 2 + x, 0, -mapSize.y / 2 + 0.5f + y);
                    Transform newLine = Instantiate(linePrefab, linePosition, Quaternion.identity) as Transform;
                    newLine.parent = newTile;
                    newLine.gameObject.SetActive(false);
                }
            }
        }
    }
}
