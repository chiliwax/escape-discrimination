using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class press_any_key : MonoBehaviour
{
    public string _scene;
    void Update()
    {
        if (Input.anyKey)
            SceneManager.LoadScene(_scene);
    }
}
