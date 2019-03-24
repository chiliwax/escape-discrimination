using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;
public class press_any_key : MonoBehaviour
{
    private bool loadScene = false;

    public string _scene;
    public TextMeshProUGUI textContainer;
    void Update()
    {
        if (Input.anyKey)
        {
            if (loadScene == false)
            {
                loadScene = true;
                textContainer.text = "Loading...";
                textContainer.color = Color.yellow;
                StartCoroutine(LoadSceneAsync());
                SceneManager.LoadScene(_scene);
            }
        }
    }
    IEnumerator LoadSceneAsync()
    {
        yield return new WaitForSeconds(3);
        AsyncOperation async = SceneManager.LoadSceneAsync(_scene);
        while (!async.isDone)
        {
            yield return null;
        }
    }
}
