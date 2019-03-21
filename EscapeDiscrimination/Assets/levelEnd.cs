using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class levelEnd : MonoBehaviour
{
    public float boys_points;
    public float old_man_points;
    public float woman_points;
    public float little_girl_points;
    public GameObject _DialogBox;
    public Transform _spawn;
    public string _sceneName;
    private GameObject _InstanciateDialog = null;

    void OnTriggerEnter2D(Collider2D col)
    {
        if (LayerMask.LayerToName(col.gameObject.layer) == "Player")
        {
            Debug.Log("enter in end");
            _InstanciateDialog = Instantiate(_DialogBox, _spawn);
            _InstanciateDialog.GetComponentInChildren<End_windows>().boy = boys_points;
            _InstanciateDialog.GetComponentInChildren<End_windows>().littleGirl = little_girl_points;
            _InstanciateDialog.GetComponentInChildren<End_windows>().oldMan = old_man_points;
            _InstanciateDialog.GetComponentInChildren<End_windows>().Woman = woman_points;
            _InstanciateDialog.GetComponentInChildren<End_windows>()._sceneName = _sceneName;
            _InstanciateDialog.GetComponentInChildren<End_windows>().Calculate();
        }
    }
}
