using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class For_Just_Level02m : MonoBehaviour
{
    public BoxCollider startWall_collider;
    public MeshRenderer startWall_Renderer;

    public BoxCollider startWall1m;

    public getMore_TIme gmt;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.tag == "lap1")
        {
            startWall1m.enabled = false;
        }

        if (collision.collider.tag == "lap2")
        {
            startWall_collider.enabled = true;
            startWall_Renderer.enabled = true;
        }

        if (collision.collider.tag == "lap3")
        {
            startWall_collider.enabled = false;
            startWall_Renderer.enabled = false;

            gmt.cur_checkpoint += 1;
            gmt.checkPoint_txt.text = gmt.cur_checkpoint.ToString();

            gmt.current_time = gmt.set_new_timerValue.timer;
            gmt.current_time += gmt.time_increment;
            gmt.set_new_timerValue.timer = gmt.current_time;
        }

    }
}
