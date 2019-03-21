using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class levelEnd : MonoBehaviour
{
    public float _TimeBeforSpawn;
    public GameObject _GameObjectToTrigger;
    public Animator _animation;
     void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject == _GameObjectToTrigger)
        {
            StartCoroutine(Cinematique());
        }
    }
    IEnumerator Cinematique()
    {
        yield return new WaitForSeconds(_TimeBeforSpawn);
        _animation.gameObject.SetActive(true);
        _animation.enabled = true;
        
        //_animation.SetBool("End", true);   
        //_animation.SetBool("End", false);
        //Debug.Log("End !!!"); 
        yield return new WaitForSeconds(4);
        Destroy(this);
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
