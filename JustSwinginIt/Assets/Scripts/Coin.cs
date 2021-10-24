using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    public int coinValue = 1;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
            UnityEngine.Debug.Log("COin collision log");
            ScoreManager.instance.ChangeScore(coinValue);
    }
}
