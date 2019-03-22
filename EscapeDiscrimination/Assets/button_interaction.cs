using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class button_interaction : MonoBehaviour
{
    public Sprite activate_button;
    public UnityEngine.Events.UnityEvent button_trigger;
 void OnTriggerEnter2D(Collider2D col)
    {
        if (LayerMask.LayerToName(col.gameObject.layer) == "Player")
        {
            GetComponent<SpriteRenderer>().sprite = activate_button;
            button_trigger.Invoke();
        }
    }
}
