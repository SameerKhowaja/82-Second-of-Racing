using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class For_Just_lvl03m : MonoBehaviour
{
    public getMore_TIme gmt;

    public BoxCollider startWall_C;
    public MeshRenderer startWall_MR;

    public BoxCollider startWall1_C;

    void Update()
    {
        if (gmt.cur_checkpoint == 2)
        {
            startWall_C.enabled = true;
            startWall_MR.enabled = true;
        }

        if (gmt.cur_checkpoint == 3)
        {
            startWall_C.enabled = false;
            startWall_MR.enabled = false;

            startWall1_C.enabled = false;
        }

    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.tag == "lap3")
        {
            gmt.cur_checkpoint += 1;
            gmt.checkPoint_txt.text = gmt.cur_checkpoint.ToString();

            gmt.current_time = gmt.set_new_timerValue.timer;
            gmt.current_time += 30f;
            gmt.set_new_timerValue.timer = gmt.current_time;
        }

    }

}
