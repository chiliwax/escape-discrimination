using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class End_windows : MonoBehaviour
{
    public float boy = 0;
    public float oldMan = 0;
    public float Woman = 0;
    public float littleGirl = 0;
    public GameObject stars1;
    public GameObject stars2;
    public string _sceneName;
    private float _somme1;
    private float _somme2;

    public void Calculate()
    {
        _somme1 = boy + oldMan + Woman + littleGirl;
        _somme2 = Social_static.social_boy + Social_static.social_little_girl + Social_static.social_old_man + Social_static.social_woman;

        if (_somme2 >= _somme1 / 2) 
        {
            stars1.SetActive(true);
        }
        if (_somme2 >= _somme1)
        {
            stars2.SetActive(true);
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Return))
        {
            Debug.Log("enter pressed");
            SceneManager.LoadScene(_sceneName);
        }
    }
}
