using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lvl3_plateform_activator : MonoBehaviour
{
    public GameObject plateform;

    void Update()
    {
        if (GetComponent<CharacterController2D>().enabled) 
        {
            plateform.GetComponent<Collider2D>().enabled = true;
            plateform.GetComponent<SpriteRenderer>().enabled = true;
        }
        else
        {
            plateform.GetComponent<Collider2D>().enabled = false;
            plateform.GetComponent<SpriteRenderer>().enabled = false;
        }
    }
}
