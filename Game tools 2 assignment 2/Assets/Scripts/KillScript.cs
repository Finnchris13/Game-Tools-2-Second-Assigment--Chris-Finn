using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class KillScript : MonoBehaviour {

    private Animator m_anim;
    private NavMeshAgent m_nav;
    private AudioSource m_audio;
    public AudioClip Clip;
    public AudioClip Hit;

	// Use this for initialization
	void Start () {
        m_anim = GetComponent<Animator>();
        m_nav = GetComponent<NavMeshAgent>();
        m_audio = GetComponent<AudioSource>();

    }
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Arrow" || other.tag == "Death")
        {

            m_anim.SetBool("Dead", true);
            ScoreScript.scoreValue += 50;
            GetComponent<EnemyAIScript>().enabled = false;
            m_nav.isStopped = true;
            GetComponent<CapsuleCollider>().enabled = false;
            /*GetComponent<ObjectPooler>().enabled = true;*/
            GetComponent<ObjectSpawner>().enabled = true;
            m_audio.PlayOneShot(Clip, 0.7f);
            Destroy(gameObject, 3);

        }

        if(other.tag == "Player")
        {
            m_anim.SetBool("Hit", true);
            PlayerHealthPoints.playerHealth -= 5;
            m_nav.isStopped = true;
            m_audio.PlayOneShot(Hit, 0.7f);
        }

    }

    private void OnTriggerExit(Collider other)
    {
        if(other.tag == "Player")
        {
            m_anim.SetBool("Hit", false);
            m_nav.isStopped = false;
        }
    }
}
