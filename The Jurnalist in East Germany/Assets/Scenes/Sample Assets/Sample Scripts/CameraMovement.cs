using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    public GameObject player;

    void Update () {
        Vector3 offset = transform.position - player.transform.position;
        bool changeInX = false;
        Vector3 newCameraPosition = transform.position;
        if (offset.x > 6)
        {
            changeInX = true;
            newCameraPosition.x = (player.transform.position.x + offset.x) - (offset.x - 6);
        }
        else if (offset.x < -6)
        {
            changeInX = true;
            newCameraPosition.x = (player.transform.position.x + offset.x) - (offset.x + 6);
        }
        if (!changeInX)
        {
            newCameraPosition.x = transform.position.x;
        }
        transform.position = newCameraPosition;
 }
}
