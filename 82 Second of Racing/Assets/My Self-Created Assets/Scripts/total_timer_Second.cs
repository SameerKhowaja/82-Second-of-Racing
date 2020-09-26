using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class total_timer_Second : MonoBehaviour
{
    public Text TotalTime_txt;
    public decrease_Timer_Count dtc;

    void Update()
    {
        TotalTime_txt.text = dtc.total_time_taken.ToString("0.00");
    }
}
