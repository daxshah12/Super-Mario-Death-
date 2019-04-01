using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HUD : MonoBehaviour {

    // public Sprite[] HeartSprites;
    public Playermovement player;


    public GameObject heart1, heart2, heart3;
    public static int health;

   

    private void Start()
    {
        health = 3;
        heart1.gameObject.SetActive(true);
        heart2.gameObject.SetActive(true);
        heart3.gameObject.SetActive(true);
       // gameover.gameObject.SetActive(false);
    }

    private void Update()
    {
        if(player.transform.position.y < 7.3)
        {
            Debug.Log("Hello");
        if(health > 3)
         health = 3;

            switch (health)
            {
                case 2:
                        heart1.gameObject.SetActive(true);
                        heart2.gameObject.SetActive(true);
                        heart3.gameObject.SetActive(false);
                        break;
                    
                case 1:

                    heart1.gameObject.SetActive(true);
                    heart2.gameObject.SetActive(false);
                    heart3.gameObject.SetActive(false);
                    break;

                case 0:

                    heart1.gameObject.SetActive(false);
                    heart2.gameObject.SetActive(false);
                    heart3.gameObject.SetActive(false);
                    Time.timeScale = 0;
                    break;

                //case 0:

                //    heart1.gameObject.SetActive(false);
                //    heart2.gameObject.SetActive(false);
                //    heart3.gameObject.SetActive(false);
                //    Time.timeScale = 0;
                //    break;
            }
        }
    }



}
