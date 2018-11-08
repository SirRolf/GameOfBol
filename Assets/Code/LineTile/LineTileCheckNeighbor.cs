using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LineTileCheckNeighbor : MonoBehaviour {

    void Awake()
    {
        RaycastHit hit;
        if (Physics.Raycast(this.transform.position, Vector3.right, out hit, 1))
        {
            Debug.Log("Did Hit");
        }
        else
        {
            Debug.Log("Did not Hit");
        }
    }
}
