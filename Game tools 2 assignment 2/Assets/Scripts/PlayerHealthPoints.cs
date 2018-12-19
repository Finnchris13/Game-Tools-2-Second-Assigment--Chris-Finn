using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlayerHealthPoints : MonoBehaviour
{

    public static int playerHealth = 100;
    Text health;
    

    // Use this for initialization
    void Start()
    {

        health = GetComponent<Text>();


    }

    // Update is called once per frame
    void Update()
    {

        health.text = "Health:" + playerHealth;

        /* if (playerHealth == 0)
         {
              SceneManager.LoadScene(3);
             m_anim.SetBool("Death", true);
         }
     }*/
    }


}
