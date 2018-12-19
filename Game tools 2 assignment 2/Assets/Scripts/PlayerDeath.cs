using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerDeath : MonoBehaviour {

   

    private Animator m_anim;
    float SceneLoadTime = 3;
    

    // Use this for initialization
    void Start () {
        m_anim = GetComponent<Animator>();
        
    }

    // Update is called once per frame
    void Update () {

        if (PlayerHealthPoints.playerHealth <= 0)
        {
            
            m_anim.SetBool("Death", true);
            GetComponent<ObjectSpawner>().enabled = true;
            Invoke("GoToScene", SceneLoadTime);
            

        }

  

    }

    private void OnTriggerEnter(Collider other)
    {
        
        if (other.tag == "Death")
        {

            PlayerHealthPoints.playerHealth = 0;
       
        }

    }

    void GoToScene()
    {
        SceneManager.LoadScene(3);
    }

}
