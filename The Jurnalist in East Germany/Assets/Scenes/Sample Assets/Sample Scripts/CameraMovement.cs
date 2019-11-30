﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    public GameObject player;

    void Update () {
        Vector3 offset = transform.position - player.transform.position;
        bool changeInX = false;
        Vector3 newCameraPosition = transform.position;
        if (offset.x > 4)
        {
            changeInX = true;
            if(transform.position.x > -22)
                newCameraPosition.x = (player.transform.position.x + offset.x) - (offset.x - 4);
            else
            {
                newCameraPosition = transform.position;
            }
        }
        else if (offset.x < -4)
        {
            changeInX = true;
            if(transform.position.x < 16)
                newCameraPosition.x = (player.transform.position.x + offset.x) - (offset.x + 4);
                else
            {
                newCameraPosition = transform.position;
            }
        }
        if (!changeInX)
        {
            newCameraPosition.x = transform.position.x;
        }
        transform.position = newCameraPosition;
 }
}
