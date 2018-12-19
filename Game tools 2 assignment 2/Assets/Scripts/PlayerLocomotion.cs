using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerLocomotion : MonoBehaviour {

    private Animator m_anim;

    

	void Start () {
        m_anim = GetComponent<Animator>();

	}

    private void Update()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            m_anim.SetBool("Jump", true);
        }
        else
        {
            m_anim.SetBool("Jump", false);
        }

        if (Input.GetKey(KeyCode.LeftShift))
        {
            m_anim.SetBool("Sprinting", true);
        }
        else
        {
            m_anim.SetBool("Sprinting", false);
        }
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            SceneManager.LoadScene(0);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Finish")
        {
            ScoreScript.scoreValue += 2500;
        }
    }

    public void Move(float forward, float turn)
    {
        m_anim.SetFloat("IsWalking", forward);
        m_anim.SetFloat("IsTurning", turn);
    }
}
