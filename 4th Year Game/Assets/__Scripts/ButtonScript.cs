using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonScript : MonoBehaviour
{
    public GameObject Box;
    public Transform spawnpoint1;
    public Transform spawnpoint2;
    public Rigidbody2D player;
    public Renderer boxRenderer;

    [SerializeField]
    private Color boxColor;
    [SerializeField]
    private AudioSource actionSound;

    // Update is called once per frame
    private void Start()
    {
        //boxRenderer = Box.gameObject.GetComponent<Renderer>();
        boxRenderer = GameObject.Find("Box").GetComponent<Renderer>();  //  Find the renderer of the box prefab
    }


    public void OnTriggerStay2D(Collider2D col)
    {
        if (player) //  If it's the player in the collider trigger
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                Box = Instantiate(Box, spawnpoint1.position, Quaternion.identity);
                boxRenderer = Box.transform.GetComponent<Renderer>();
                boxRenderer.material.color = boxColor;  //  change the color after it is instantiated
				//	box.tag = "redBox";
				//	or
				//	if(boxcolor == red){	box.tag = "redBox"}
                actionSound.Play();
            }
        }

    }

}
