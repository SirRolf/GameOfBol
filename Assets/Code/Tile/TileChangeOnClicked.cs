using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TileChangeOnClicked : MonoBehaviour {

    private GameObject gameManager;

    void Awake()
    {
        gameManager = GameObject.Find("GameManager");
    }

	public void ChangeTile()
    {
        for (int i = 0; i < gameObject.transform.childCount; i++)
        {
            var child = gameObject.transform.GetChild(i).gameObject;
            if (child != null)
            {
                child.SetActive(true);
                gameManager.GetComponent<GameManagerLineLocations>().ConvertTile(child.transform.position.x, child.transform.position.z);
            }
            else
            {
                print("child is gone");
            }
                
        }
    }

}
