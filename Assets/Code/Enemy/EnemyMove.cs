using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMove : MonoBehaviour {

    private GameObject gameManager;

    // 0=top 1=right 2=bot 3=left
    Vector3[] adjacentTiles = new Vector3[4];

    List<Vector3> visitedLines = new List<Vector3>();

    Vector3 end = new Vector3(7,0,-0.5f);

    int changableDir;

    [SerializeField]
    private float speed;

    void Awake ()
    {
        gameManager = GameObject.Find("GameManager");
        CheckAdjacentTiles();
    }

	void Update ()
    {
        move(changableDir);
	}

    void CheckAdjacentTiles()
    {
        adjacentTiles[0] = new Vector3(this.gameObject.transform.position.x, this.gameObject.transform.position.y, this.gameObject.transform.position.z + 1);
        adjacentTiles[1] = new Vector3(this.gameObject.transform.position.x + 1, this.gameObject.transform.position.y, this.gameObject.transform.position.z);
        adjacentTiles[2] = new Vector3(this.gameObject.transform.position.x, this.gameObject.transform.position.y, this.gameObject.transform.position.z - 1);
        adjacentTiles[3] = new Vector3(this.gameObject.transform.position.x - 1, this.gameObject.transform.position.y, this.gameObject.transform.position.z);

        List<Vector3> convertedTiles = gameManager.GetComponent<GameManagerLineLocations>().convertedTiles;

        //check if you can go top
        if (convertedTiles.Contains(adjacentTiles[0]) && !visitedLines.Contains(adjacentTiles[0]))
        {
            changableDir = 0;
        }
        //check if you can go right
        else if (convertedTiles.Contains(adjacentTiles[1]) && !visitedLines.Contains(adjacentTiles[1]))
        {
            changableDir = 1;
        }
        //check if you can go bot
        else if (convertedTiles.Contains(adjacentTiles[2]) && !visitedLines.Contains(adjacentTiles[2]))
        {
            changableDir = 2;
        }
        //check if you can go left
        else if (convertedTiles.Contains(adjacentTiles[3]) && !visitedLines.Contains(adjacentTiles[3]))
        {
            changableDir = 3;
        }

        for (int i = 0; i < 3; i++)
        {
            if (end == adjacentTiles[i])
            {
                changableDir = i;
            }
        }
    }

    void move(int dir)
    {
        transform.position = Vector3.MoveTowards(transform.position, adjacentTiles[dir], speed * Time.deltaTime);
        if(transform.position == adjacentTiles[dir])
        {
            visitedLines.Add(adjacentTiles[dir]);
            CheckAdjacentTiles();
        }
    }
}
