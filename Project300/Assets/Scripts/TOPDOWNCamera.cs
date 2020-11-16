﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TOPDOWNCamera : MonoBehaviour
{
    public Transform Player;
    public float Smooth = 0.3f;
    public float height;
    private Vector3 velocity = Vector3.zero;
 void Update()
        {

        Vector3 pos = new Vector3();
        pos.x = Player.position.x;
        pos.z = Player.position.z - 7f;
        pos.y = Player.position.y+height;
        transform.position = Vector3.SmoothDamp(transform.position, pos, ref velocity, Smooth);
        }
}
