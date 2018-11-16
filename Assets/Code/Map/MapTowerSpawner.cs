using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapTowerSpawner : MonoBehaviour {

    //cooldown is how long it takes from creating till the next one
    //actualCooldown is how long it takes from current time till it spawns

    //q=splitter
    [SerializeField]
    private float qCooldown;
    private float qActualCooldown;
    [SerializeField]
    private GameObject splitter;
    
    void Awaken()
    {
        qActualCooldown = qCooldown;
    }

    void Update()
    {
        qActualCooldown += Time.deltaTime;
    }

    public void useQ (Vector3 loc)
    {
        //use your Q / make slitter
        if (qActualCooldown >= qCooldown)
        {
            Instantiate(splitter, loc, Quaternion.identity);
        }
    }

}
