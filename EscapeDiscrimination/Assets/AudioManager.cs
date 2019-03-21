using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    public AudioSource _audio;
    // Start is called before the first frame update
    public AudioClip[] _clips;
    [HideInInspector]
    public int _ID;



    void Update()
    {
        if (_audio.clip != _clips[_ID])
        {
            _audio.clip = _clips[_ID];
        }
        if (Input.GetButtonDown("Jump")) 
        {
            _audio.enabled = true;
            _audio.PlayOneShot(_clips[1], 0.25f);
        }
    }
}
