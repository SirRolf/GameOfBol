using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapRaycaster : MonoBehaviour {

    [SerializeField]
    private GameObject gameManager;

    void Update()
    {
        RaycastHit hit;
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

        if (Physics.Raycast(ray, out hit, 100f) && Input.GetMouseButton(0))
        {
            if (hit.transform != null && hit.transform.tag == "Tile")
            {
                hit.transform.GetComponent<TileChangeOnClicked>().ChangeTile();
            }
        }
        if (Physics.Raycast(ray, out hit, 100f) && Input.GetKeyDown("q"))
        {

            List<Vector3> convertedTiles = gameManager.GetComponent<GameManagerLineLocations>().convertedTiles;
            if (hit.transform != null && convertedTiles.Contains(hit.transform.position))
            {
                this.GetComponent<MapTowerSpawner>().useQ(hit.transform.position);
            }
        }
    }
}
