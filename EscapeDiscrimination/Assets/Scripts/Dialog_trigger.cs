using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Dialog_trigger : MonoBehaviour
{
    public float _TimeBeforSpawn;
    public float _LifeDuration;
 //   public Transform _DialogSpawn;
    public GameObject _DialogSpawnCharacter;
    public string _Dialog;
    public GameObject _DialogBox;
    public GameObject _GameObjectToTrigger;
    private GameObject _InstanciateDialog = null;
    private bool is_running = false;

    private bool set_active = true;

    void OnTriggerEnter2D(Collider2D col)
    {
        if (set_active == true && col.gameObject == _GameObjectToTrigger && is_running == false)
        {
            set_active = false;
            Debug.Log(col.gameObject.name);
            StartCoroutine(DisplayDialog());
        }
    }

    IEnumerator DisplayDialog()
    {
        yield return new WaitForSeconds(_TimeBeforSpawn);
        is_running = true;
        //_InstanciateDialog = Instantiate(_DialogBox, _DialogSpawn);
        _InstanciateDialog = Instantiate(_DialogBox, _DialogSpawnCharacter.transform.Find("DialogAnchor").transform);
        _InstanciateDialog.GetComponentInChildren<TextMeshPro>().text = _Dialog;
        _InstanciateDialog.GetComponentInChildren<TxtController>()._parent = _DialogSpawnCharacter;
        yield return new WaitForSeconds(_LifeDuration);
        if (_InstanciateDialog)
        {
            Debug.Log("destroy");
            Destroy(_InstanciateDialog);
        }
        Destroy(this);
    }

}
