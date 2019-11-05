using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boundaries : MonoBehaviour
{
    // get the main camera
    // get the bounds of it (X,Y) - half the size
    // use Mathf.Clamp to compare the min, max to the current x

    // == public properties ==
    public Camera mainCamera;

    // == private fields ==
    private Vector2 screenBound;
    private float width;
    private float height;

    // Start is called before the first frame update
    void Start()
    {
        // find the bounds from the camera
        screenBound = mainCamera.ScreenToWorldPoint(
                                new Vector3(Screen.width,
                                            Screen.height,
                                            mainCamera.transform.position.z));
        Debug.Log("Screen width = " + screenBound.x);
        width = gameObject.GetComponent<SpriteRenderer>().bounds.extents.x;
        height = gameObject.GetComponent<SpriteRenderer>().bounds.extents.y;
    }

    // after the player moves, need to check that they are in bounds
    // player moves on the update method.  Can't use the update - need to 
    // ensure this is done after Update -> LateUpdate
    private void LateUpdate()
    {
        Vector3 viewPos = transform.position;
        // find the position of X and clamp
        // find the position of Y and clamp
        viewPos.x = Mathf.Clamp(viewPos.x,
                                screenBound.x * -1 + (width * 0.4f),
                                screenBound.x - width);
        viewPos.y = Mathf.Clamp(viewPos.y,
                                screenBound.y * -1 + (width * 0.4f),
                                screenBound.y - height);

        transform.position = viewPos;
    }
}
