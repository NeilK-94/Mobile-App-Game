using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerCheck : MonoBehaviour
{
    //public GameObject block1;
    public Collider2D trigCol;
    public Rigidbody2D block1;

    public void Start()
    {
        trigCol = GetComponent<Collider2D>();
    }
    public void OnTriggerStay2D(Collider2D collision)
    {
        if (block1)
        {
            Debug.Log("Green block");
            //  Code here to finish level
        }
    }
}
