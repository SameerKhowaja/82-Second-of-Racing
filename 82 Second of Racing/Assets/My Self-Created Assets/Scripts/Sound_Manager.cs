using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sound_Manager : MonoBehaviour
{
    public AudioSource[] audiosource;
    public int number;

    void Start()
    {
        number = 0;
        audiosource[number].Play();
    }
    
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.C))
        {
            if (number >= 0 && number < audiosource.Length - 1)
            {
                audiosource[number].Stop();
                number += 1;
                audiosource[number].Play();
            }
            else if (number == audiosource.Length -1)
            {
                audiosource[number].Stop();
                number += 1;
            }
            else if (number == audiosource.Length)
            {
                number = 0;
                audiosource[number].Play();
            }
            
        }

        
    }
}
