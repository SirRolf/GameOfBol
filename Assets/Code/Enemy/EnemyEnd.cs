using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyEnd : MonoBehaviour {

    private GameObject gameManager;
    private Vector3 end = new Vector3(7, 0, 0);
    private Vector3 curPos = new Vector3();

    [SerializeField]
    private float damage;

    void Awake ()
    {
        gameManager = GameObject.Find("GameManager");
    }

    // Update is called once per frame
    void Update () {
        curPos.x = Mathf.Round(transform.position.x);
        curPos.z = Mathf.Round(transform.position.z);
        if (curPos == end)
        {
            gameManager.GetComponent<GameManagerHealth>().RemoveHealth(damage);
            Destroy(gameObject);
        }
	}
}
