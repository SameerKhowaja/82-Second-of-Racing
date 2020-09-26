using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class decrease_Timer_Count : MonoBehaviour
{
    public Text timer_txt;
    public float timer;
    public float total_time_taken;

    void Start()
    {
        timer = float.Parse(timer_txt.text);
    }

    void Update()
    {
        if(timer > 0)
        {
            timer -= Time.fixedDeltaTime;
            total_time_taken += Time.fixedDeltaTime;
            timer_txt.text = timer.ToString("0");
        }
    }
}
