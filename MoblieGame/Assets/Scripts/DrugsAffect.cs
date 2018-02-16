using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DrugsAffect : MonoBehaviour
{
    //  public string Color = Green;
    public int num = 4;
    public float timer = 0.0f;
    public float R = 255f;
    public float G = 0f;
    public float B = 0f;


    // Use this for initialization
    void Start()
    {
        GetComponent<SpriteRenderer>().color = new Color(R, B, G);
    }

    // Update is called once per frame
    void Update()
    {
        GetComponent<SpriteRenderer>().color = new Color(R, B, G);

        timer += Time.deltaTime;
        /*  if (timer >= 1 && num >= 0)
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

        if (R >= 254f)
        {
            B++;
        }
        if (B >= 254f)
        {
            R--;
        }
        if (R <= 1f && B >= 254f)
        {
            G++;
        }
        if (G >= 254f)
        {
            R++;
        }
        if (R >= 254f && G >= 254f)
        {
            G--;
        }
        if (R <= 0 || G <= 0 || B <= 0)
        {
            R++;
            G++;
            B++;
        }
        if (R >= 255f || G >= 255f || B >= 255f)
        {
            R--;
            G--;
            B--;
            R--;
            G--;
            B--;

        }
        {



            /*    if (num == 1)
                    {
                        GetComponent<SpriteRenderer>().color = GetComponent<SpriteRenderer>().color = Color.green;
                    }
                   if (num == 2)
                   {

                    GetComponent<SpriteRenderer>().color = GetComponent<SpriteRenderer>().color = Color.blue;

                   }
                    if (num == 3) {
                        GetComponent<SpriteRenderer>().color = GetComponent<SpriteRenderer>().color = Color.red;
                    }
                    */
            if (num == 4)
            {
                GetComponent<SpriteRenderer>().color = GetComponent<SpriteRenderer>().color = new Color(R, B, G);
            }


        }
    }
}
