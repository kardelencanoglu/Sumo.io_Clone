using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public Transform player;
    private Vector3 offset;
    public float smoothSpeed;

    void Start()
    {
        offset = transform.position - player.position;
    }

    
    void Update()
    {
        Vector3 newPos = Vector3.Lerp(transform.position, offset + player.position, smoothSpeed);
        transform.position = newPos;
    }
}