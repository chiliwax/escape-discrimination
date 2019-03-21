using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Dialog_trigger : MonoBehaviour
{
    public float _TimeBeforSpawn;
    public float _LifeDuration;
    public Transform _DialogSpawn;
    public string _Dialog;
    public GameObject _DialogBox;
    public GameObject _GameObjectToTrigger;
    private GameObject _InstanciateDialog = null;
    private bool is_running = false;

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject == _GameObjectToTrigger && is_running == false)
        {
            StartCoroutine(DisplayDialog());
        }
    }

    IEnumerator DisplayDialog()
    {
        yield return new WaitForSeconds(_TimeBeforSpawn);
        is_running = true;
        _InstanciateDialog = Instantiate(_DialogBox, _DialogSpawn);
        _InstanciateDialog.GetComponentInChildren<TextMeshPro>().text = _Dialog;
        yield return new WaitForSeconds(_LifeDuration);
        if (_InstanciateDialog)
        {
            Destroy(_InstanciateDialog);
        }
        Destroy(this);
    }

}
