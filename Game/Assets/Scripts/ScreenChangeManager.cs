using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScreenChangeManager : MonoBehaviour
{
    public WinPad OnTriggerEnter;
    Animator anim;

    void Start()
    {
        anim = GetComponent<Animator>();
    }

    private void OnCollisionEnter(Collision collision)
    {
        anim.Play("ScreenChange");
    }
}