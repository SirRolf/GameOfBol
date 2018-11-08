using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RelocateToGrid : MonoBehaviour {

    void Awake()
    {
        transform.position = new Vector3(Mathf.Round(transform.position.x), Mathf.Round(transform.position.y), 0);
    }
}
