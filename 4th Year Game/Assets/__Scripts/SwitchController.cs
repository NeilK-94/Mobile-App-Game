using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchController : MonoBehaviour
{
    public Collider2D switchCollider;
    public Rigidbody2D player;

    void Start()
    {
        switchCollider = GetComponent<Collider2D>();
    }

    private void OnTriggerStay2D(Collider2D col)
    {
        // var player = col.GetComponent<PlayerController>();
        var actionBtn = PlayerController.action;
        if (player)
        {
            Debug.Log("Collided");

            if (Input.GetKeyDown(KeyCode.E))
            {
                actionBtn = true;
                Debug.Log("Action Pressed");
            }

        }
    }
}
