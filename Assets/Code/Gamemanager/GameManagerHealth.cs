using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManagerHealth : MonoBehaviour {

    [SerializeField]
    private GameObject gameOver;

    [SerializeField]
    private float health;

    void Update()
    {
        if (health == 0)
        {
            Dead();
        }
    }

    public void AddHealth(float amount)
    {
        health += amount;
    }

    public void RemoveHealth(float amount)
    {
        health -= amount;
    }

    public void Dead()
    {
        gameOver.gameObject.SetActive(true);
    }
}
