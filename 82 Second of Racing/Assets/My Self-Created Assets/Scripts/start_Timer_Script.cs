using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class start_Timer_Script : MonoBehaviour
{
    public decrease_Timer_Count timer_script;
    public start_Timer_Script this_Script;
    public Directional_Light_Setup dls;

    public Canvas start_Canvas;

    void Update()
    {
        if (Input.anyKey)
        {
            start_Canvas.enabled = false;
            timer_script.enabled = true;
            dls.enabled = true;
            this_Script.enabled = false;
        }
    }

}
