using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RestartLevelTrigger : MonoBehaviour
{
 void OnTriggerEnter2D(Collider2D col)
    {
        if (LayerMask.LayerToName(col.gameObject.layer) == "Player")
        {
         SceneManager.LoadScene((SceneManager.GetActiveScene().buildIndex));
        }
    }
}
