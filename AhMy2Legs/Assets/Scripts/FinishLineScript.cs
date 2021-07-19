﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinishLineScript : MonoBehaviour
{
    public TimerScript instance;

    public void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            instance.timerActive = false;
           // AudioManagerScript.instance.Play("Finish_Music");
            FindObjectOfType<AudioManagerScript>().Play("sfx_finish");
        }
    }
}
