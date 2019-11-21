using UnityEngine;

public class ButtonScript : MonoBehaviour
{
    public GameObject Box;
    public Transform spawnpoint1;
    public Rigidbody2D player;
    public Renderer boxRenderer;

    [SerializeField]
    private AudioSource actionSound;

    public void OnTriggerStay2D(Collider2D col)
    {
        if (player) //  If it's the player in the collider trigger
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                //  Instantiate a box at the spawpoint
                Box = Instantiate(Box, spawnpoint1.position, Quaternion.identity);
                //  Set boxRenderer to be the Renderer component of the instantiated box
                boxRenderer = Box.GetComponent<Renderer>(); //  box.tranform
                
                //  Get a random number between 1 and 3, this will be used to assign the boxes thier color and tag
                int rndColor = Random.Range(1, 4);
                //Debug.Log(rndColor);

                if (rndColor == 1)
                {
                    boxRenderer.material.color = Color.red;  //  change the color after it is instantiated
                    Box.tag = "redBlock";   //  Set it's tag
                }
                else if (rndColor == 2)
                {
                    boxRenderer.material.color = Color.blue;
                    Box.tag = "blueBlock";
                }
                else
                {
                    boxRenderer.material.color = Color.green;
                    Box.tag = "greenBlock";
                }
                actionSound.Play();
            }
        }

    }

}
