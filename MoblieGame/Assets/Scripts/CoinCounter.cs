using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CoinCounter : MonoBehaviour {
    public int coins = 0;
    public float Timer = 0;
    public GameObject coinText;
    public GameObject TimerText;

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
        Timer += Time.deltaTime;
        coinText.GetComponent<Text>().text = "Coins: " + coins;
        TimerText.GetComponent<Text>().text = "Time: " + Timer;


    }
}