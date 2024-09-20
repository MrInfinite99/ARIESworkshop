using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public float FollowSpeed = 10f;  //  how fast the camera should follow the target
    public float yOffset = 1f;   //camera at some fixed height above the target
    public Transform target;

    // Update is called once per frame
    void Update()
    {
        Vector3 Pos = new Vector3(target.position.x, target.position.y + yOffset, -10f);   // setting camera position
        transform.position = Vector3.Slerp(transform.position, Pos, FollowSpeed * Time.deltaTime);  // Smoothly move the camera to the new position using Slerp
    }
}