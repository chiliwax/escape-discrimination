using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetAsChildTrigger : MonoBehaviour
{
    private Transform old_parent;
    void OnTriggerEnter2D(Collider2D col)
    {
        if (LayerMask.LayerToName(col.gameObject.layer) == "Player")
        {
            old_parent = col.transform.parent;
            col.transform.parent = this.transform;
        }
    }
    void OnTriggerExit2D(Collider2D col)
    {
        col.transform.parent = old_parent;
    }
}
