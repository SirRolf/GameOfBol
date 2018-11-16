using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SplitterDestroyer : MonoBehaviour {

    private bool destroyNextEnemy = true;

    private void OnTriggerEnter(Collider other)
    {
            Debug.Log("entered");
    }


}
