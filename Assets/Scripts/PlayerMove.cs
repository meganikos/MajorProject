using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    public float speed;
    float xDirection;
    float zDirection;

    void Start()
    {

    }

    void Update()
    {
        xDirection = Input.GetAxis("Horizontal");
        zDirection = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3( xDirection,0.0f, zDirection);

        transform.position += movement * speed;
    }
}
