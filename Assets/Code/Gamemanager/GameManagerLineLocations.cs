using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManagerLineLocations : MonoBehaviour {
    public List<Vector3> convertedTiles = new List<Vector3>();

    public void ConvertTile(float x, float y)
    {
        Vector3 addedTile = new Vector3(x,0,y);
        if(!convertedTiles.Contains(addedTile))
        {
            convertedTiles.Add(addedTile);
        }
    }
}
