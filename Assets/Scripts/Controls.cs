using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controls : MonoBehaviour
{
    private float MoveSpeed = .3f;
    private float rotateSpeed = 1.5f;
    public Joystick joystick;
    
    void Start()
    {
        joystick = FindObjectOfType<Joystick>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += transform.forward * MoveSpeed;
        
        transform.Rotate(Vector3.up * (joystick.Horizontal * rotateSpeed * 90f* Time.deltaTime));
    }
}
