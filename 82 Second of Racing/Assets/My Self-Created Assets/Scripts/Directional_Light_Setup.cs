using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Directional_Light_Setup : MonoBehaviour
{
    public Light Directional_Light, Car_Head_Light;
    public float timer, tmp;
    bool DL_isEnable = true;

    void Update()
    {
        timer -= Time.fixedDeltaTime;
        if(timer <= 0)
        {
            if (DL_isEnable == true)
            {
                Directional_Light.enabled = false;
                Car_Head_Light.enabled = true;
                DL_isEnable = false;
            }
            else
            {
                Directional_Light.enabled = true;
                Car_Head_Light.enabled = false;
                DL_isEnable = true;
            }

            timer = tmp;
        }
    }

}
