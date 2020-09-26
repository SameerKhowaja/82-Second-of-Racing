using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CarController : MonoBehaviour
{
    private float m_horizontalInput, m_verticleInput, m_steerAngle;
    public WheelCollider wheel1, wheel2, wheel3, wheel4;
    public Transform wheel1T, wheel2T, wheel3T, wheel4T;
    public float maxSteerAngle;
    public float motorForce;
    public Reload_Scene reload_lvl;

    public void GetInput()
    {
        m_horizontalInput = Input.GetAxis("Horizontal");
        m_verticleInput = Input.GetAxis("Vertical");
    }
    private void Steer()
    {
        m_steerAngle = maxSteerAngle * m_horizontalInput;
        wheel1.steerAngle = m_steerAngle;
        wheel2.steerAngle = m_steerAngle;
    }
    private void Acceleration()
    {
        wheel1.motorTorque = m_verticleInput * motorForce;
        wheel2.motorTorque = m_verticleInput * motorForce;
    }
    private void UpdateWheelPosses()
    {
        UpdateWheelPose(wheel1, wheel1T);
        UpdateWheelPose(wheel2, wheel2T);
        UpdateWheelPose(wheel3, wheel3T);
        UpdateWheelPose(wheel4, wheel4T);
    }
    private void UpdateWheelPose(WheelCollider collider, Transform transform)
    {
        Vector3 pos = transform.position;
        Quaternion quant = transform.rotation;

        collider.GetWorldPose(out pos, out quant);
        transform.position = pos;
        transform.rotation = quant;
    }

    private void FixedUpdate()
    {
        GetInput();
        Steer();
        Acceleration();
        UpdateWheelPosses();
    }

    public void Update()
    {
        if (Input.GetKey(KeyCode.R))
        {
            reload_lvl.enabled = true;
        }

        if (Input.GetKey(KeyCode.M))
        {
            SceneManager.LoadScene("MainScene");
        }
    }
}
