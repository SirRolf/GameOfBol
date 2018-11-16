using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMoveWhenBuilt : MonoBehaviour {

    private bool readyToMove = false;

    private float timer = 0;

    [SerializeField]
    private float speedLocation;
    [SerializeField]
    private float speedRotation;
    [SerializeField]
    private Vector3 readyLocation= new Vector3();
    [SerializeField]
    private Vector3 readyRotation = new Vector3();
    [SerializeField]
    private float durationRotation;

    void Update () {
        if (Input.GetKeyDown("space"))
        {
            readyToMove = true;
        }
        else if (readyToMove == true)
        {
            transform.position = Vector3.MoveTowards(transform.position, readyLocation, speedLocation * Time.deltaTime);
            transform.RotateAround(Vector3.zero, readyRotation, speedRotation * Time.deltaTime);
            timer += Time.deltaTime;
            if (timer > durationRotation)
            {
                readyToMove = false;
            }
        }
    }
}
