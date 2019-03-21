using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Social_trigger : MonoBehaviour
{
    public GameObject _GameObjectToTrigger;
    private bool is_running = false;
      [Header("Social Settings")]
    public float gain;
    public enum Who{ OldMan, Woman, Boy, Littlegirl }
    public Who _Who;
    public GameObject _notif;

   void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject == _GameObjectToTrigger && is_running == false)
        {
            GainXp();
        }
    }
 void GainXp()
    {
        if (_Who == Who.OldMan && (gain > 0 || gain < 0)) {
            Social_static.social_old_man += gain;
            _notif.SetActive(true);
        }

        if (_Who == Who.Woman && (gain > 0 || gain < 0)) {
            Social_static.social_woman += gain;
            _notif.SetActive(true);
        }

        if (_Who == Who.Boy && (gain > 0 || gain < 0)) {
            Social_static.social_boy += gain;
            _notif.SetActive(true);
        }

        if (_Who == Who.Littlegirl && (gain > 0 || gain < 0)) {
            Social_static.social_little_girl += gain;
            _notif.SetActive(true);
        }
        Destroy(this);
    }
}
