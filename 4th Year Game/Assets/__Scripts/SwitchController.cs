using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchController : MonoBehaviour
{
    public Collider2D switchCollider;
    public Rigidbody2D player;
    public GameObject plat1;

    private Renderer rend;

    [SerializeField]
    private Color colorToTurnTo;

    [SerializeField]
    private AudioSource actionSound;

    void Start()
    {
        switchCollider = GetComponent<Collider2D>();
        rend = GetComponent<Renderer>();
    }

    public void OnTriggerStay2D(Collider2D col)
    {
        if (player) //  If it's the player in the collider trigger
        {
            if (Input.GetKeyDown(KeyCode.E))    //If the player presses 'E' 
            {
                Destroy(plat1); //  Destroy the platform
                rend.material.color = colorToTurnTo;
                actionSound.Play();
            }
        }
    }
}
