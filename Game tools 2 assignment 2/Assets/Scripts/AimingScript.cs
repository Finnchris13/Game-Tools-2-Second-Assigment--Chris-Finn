using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AimingScript : MonoBehaviour
{

    private Animator m_anim;

    AudioSource m_audio;
    public AudioClip Clip;
    public AudioClip Arrow;
    

    void Start()
    {
        m_anim = GetComponent<Animator>();
        m_audio = GetComponent<AudioSource>();
    }

    private void Update()
    {
        if (Input.GetMouseButton(1))
        {
            m_anim.SetBool("isAiming", true);
        }
        else
        {
            m_anim.SetBool("isAiming", false);
        }

        if (Input.GetMouseButton(1) && Input.GetMouseButtonDown(0))
        {
            m_anim.SetBool("Shoot", true);
            m_audio.PlayOneShot(Arrow, 0.7f);
        }
        else
        {
            m_anim.SetBool("Shoot", false);
        }
        if(Input.GetMouseButtonDown(1))
        {
            m_audio.PlayOneShot(Clip, 0.7f);
        }
    }
}
