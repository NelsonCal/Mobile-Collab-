using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CoinCounter : MonoBehaviour {
    public int coins = 0;

    public GameObject coinText;


    void OnTriggerEnter2D(Collider2D MyCollisionInfo)
    {
        Debug.Log(MyCollisionInfo.gameObject.name);
        if (MyCollisionInfo.gameObject.tag == "Coin")
        {
            Destroy(MyCollisionInfo.gameObject);
            coins += 1;
        }
    }
    void Update()
    {
        coinText.GetComponent<Text>().text = "Coins: " + coins;


    }
}