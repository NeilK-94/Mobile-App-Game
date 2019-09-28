using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    //add player to this tranform layer
    public Transform player;

    void Update()
    {
        FollowPlayer();
    }

    private void FollowPlayer()
    {
        //  Get the x and y positions of the players transform
        var getPlayerX = player.transform.position.x;
        var getPlayerY = player.transform.position.y;
        transform.position = new Vector3(getPlayerX, getPlayerY,-1);    //  Set the position of the transform(camera)
        //Debug.Log(getPlayerX);     
    }
}
