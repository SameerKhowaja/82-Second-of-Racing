using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class getMore_TIme : MonoBehaviour
{
    public float current_time;
    public float time_increment = 82;

    public decrease_Timer_Count set_new_timerValue;

    public BoxCollider lap1_collider;
    public MeshRenderer lap1_mesh;

    public BoxCollider lap2_collider;
    public MeshRenderer lap2_mesh;

    public Text checkPoint_txt;
    public int cur_checkpoint = 0;

    public BoxCollider startWall;

    public BoxCollider endWall;
    public MeshRenderer endWall_M;

    public Canvas endWall_Canvas;
    public Canvas gameOver_Canvas;

    public CarController carcontroller;
    public decrease_Timer_Count dtc;

    public Text Currernt_Time_txt;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.tag == "lap1")
        {
            current_time = set_new_timerValue.timer;
            current_time += time_increment;
            set_new_timerValue.timer = current_time;

            cur_checkpoint += 1;
            checkPoint_txt.text = cur_checkpoint.ToString();

            startWall.enabled = false;

            lap2_collider.enabled = true;
            lap2_mesh.enabled = true;

            lap1_collider.enabled = false;
            lap1_mesh.enabled = false;
        }

        if (collision.collider.tag == "lap2")
        {
            current_time = set_new_timerValue.timer;
            current_time += time_increment;
            set_new_timerValue.timer = current_time;

            cur_checkpoint += 1;
            checkPoint_txt.text = cur_checkpoint.ToString();

            startWall.enabled = false;

            lap1_collider.enabled = true;
            lap1_mesh.enabled = true;

            lap2_collider.enabled = false;
            lap2_mesh.enabled = false;
        }

        if (collision.collider.tag == "endWall")
        {
            // level complete
            Currernt_Time_txt.text = dtc.total_time_taken.ToString("0");
            dtc.enabled = false;
            endWall_Canvas.enabled = true;
            carcontroller.motorForce = 0f;
            carcontroller.maxSteerAngle = 0f;
        }

    }

    private void Update()
    {
        if(cur_checkpoint >= 4)
        {
            endWall.enabled = true;
            endWall_M.enabled = true;
        }

        if (dtc.timer <= 0f)
        {
            gameOver_Canvas.enabled = true;
            dtc.enabled = false;
            carcontroller.motorForce = 0f;
            carcontroller.maxSteerAngle = 0f;

            lap1_collider.enabled = false;
            lap1_mesh.enabled = false;
            lap2_collider.enabled = false;
            lap2_mesh.enabled = false;
            endWall.enabled = false;
            endWall_M.enabled = false;
        }
    }

}
