using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class AnroidJumpButton : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{
    public Button _button;
    public UnityEngine.Events.UnityEvent button_trigger;
    public UnityEngine.Events.UnityEvent button_untrigger;

    private bool _flag = false;
    void Update()
    {
        if (!ispressed && _flag == true)
        {
            _flag = false;
            button_untrigger.Invoke();
            return;
        }
        // DO SOMETHING HERE
        if (ispressed && _flag == false)
        { 
            _flag = true;
            button_trigger.Invoke();
        }
    }
    bool ispressed = false;
    public void OnPointerDown(PointerEventData eventData)
    {
        ispressed = true;
    }

    public void OnPointerUp(PointerEventData eventData)
    {
        ispressed = false;
    }
}
