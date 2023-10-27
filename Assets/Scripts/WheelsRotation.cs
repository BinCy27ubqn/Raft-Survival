using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WheelsRotation : MonoBehaviour
{
    private FloatingJoystick _floatingJoystick;

    private void Start()
    {
        _floatingJoystick = GameObject.Find("Floating Joystick").GetComponent<FloatingJoystick>();
    }

    void Update()
    {
        float hInput = _floatingJoystick.Horizontal;
        float vInput = _floatingJoystick.Vertical;

        Vector3 directionRotate = new Vector3(hInput,0,vInput);
        if (directionRotate != Vector3.zero)
        {
            transform.rotation = Quaternion.LookRotation(-directionRotate, Vector3.up);
        }
    }
}
