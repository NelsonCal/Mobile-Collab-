using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class ChangingColors : MonoBehaviour
{
    public int num = 0;
    public float timer = 0.0f;
    public bool Colors = false;
    public bool Fast = false;
    // Use this for initialization
    void Start()
    {
        GetComponent<SpriteRenderer>().color = new Color(255f, 255f, 255f);
    }

    // Update is called once per frame
    void Update()
    {
        if (Colors == true && Fast == false)
        {
            if (timer >= 2)
            {
                num = Random.Range(1, 4);
                timer = 0;
            }
        }
        if (Colors == true && Fast == true)
        {
                num = Random.Range(1, 4);
        }



        timer += Time.deltaTime;

        /*   if (timer >= 1 && num >= 0)
           {
                 num--;
                 timer = 0;
           }
             if (timer >= 1 && num <= 1 )
             {
                 num = 4;
                 timer = 0;
             }
          */
        if (Colors == false) {
            GetComponent<SpriteRenderer>().color = new Color(255f, 255f, 255f);

        }
        if (num == 1)
            {
                GetComponent<SpriteRenderer>().color = GetComponent<SpriteRenderer>().color = Color.green;
            }
            if (num == 2)
            {
                GetComponent<SpriteRenderer>().color = GetComponent<SpriteRenderer>().color = Color.blue;
            }
            if (num == 3)
            {
                GetComponent<SpriteRenderer>().color = GetComponent<SpriteRenderer>().color = Color.red;
            }
        
    }
}