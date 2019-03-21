using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[System.Serializable]
public class slider_toogle : MonoBehaviour
{
    public void GetLittleGirlSocial()
    {
        GetComponent<Slider>().value = Social_static.social_little_girl;
    }

        public void GetBoySocial()
    {
        GetComponent<Slider>().value = Social_static.social_boy;
    }

        public void GetWomanSocial()
    {
        GetComponent<Slider>().value = Social_static.social_woman;
    }

        public void GetOldManSocial()
    {
        GetComponent<Slider>().value = Social_static.social_old_man;
    }

    void Update() 
    {
        if (Social_static.active_player == "little_girl") 
        {
            GetLittleGirlSocial();
        }
        if (Social_static.active_player == "boy") 
        {
            GetBoySocial();
        }
        if (Social_static.active_player == "mother") 
        {
            GetWomanSocial();
        }
        if (Social_static.active_player == "old_man") 
        {
            GetOldManSocial();
        }
    }
}
