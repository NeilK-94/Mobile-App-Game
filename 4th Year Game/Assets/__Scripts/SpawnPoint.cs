using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/*
 * This script just draws a gizmo on the screen so we know where the spawn point is
 */
public class SpawnPoint : MonoBehaviour
{
    private void OnDrawGizmos()
    {
        Gizmos.DrawWireSphere(transform.position, 0.25f);
    }

}
