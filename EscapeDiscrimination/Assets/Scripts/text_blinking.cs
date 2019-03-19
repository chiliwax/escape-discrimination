using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class text_blinking : MonoBehaviour
{
    private bool flop = false;
    public float speed = 0;

    void Start()
    {
        StartCoroutine(Text_blinking());
    }

    IEnumerator Text_blinking()
    {

        Color color;
        TextMeshProUGUI mText = gameObject.GetComponent<TextMeshProUGUI>();

        while (true)
        {
            color = mText.color;
            if (flop == true)
            {
                color.a += 0.1f;
                if (color.a >= 1)
                {
                    flop = false;
                }
            }
            else
            {
                color.a -= 0.1f;
                if (color.a <= 0)
                {
                    flop = true;
                }
            }
            mText.color = color;
            yield return new WaitForSeconds(speed);
        }
    }


}