﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class player_manager : MonoBehaviour
{
    public GameObject[] _Players;
    public Button[] _buttons;
    public Sprite[] _activeImage;
    public Sprite[] _desactivateImage;

    void Start()
    {
        _Players[0].GetComponent<PlayerMovement>().enabled = true;
        _Players[1].GetComponent<PlayerMovement>().enabled = true;
        _Players[2].GetComponent<PlayerMovement>().enabled = true;
        _Players[3].GetComponent<PlayerMovement>().enabled = true;

        _Players[0].GetComponent<CharacterController2D>().enabled = true;
        _Players[1].GetComponent<CharacterController2D>().enabled = true;
        _Players[2].GetComponent<CharacterController2D>().enabled = true;
        _Players[3].GetComponent<CharacterController2D>().enabled = true;
    }

    public void SelectAll()
    {
        if (_Players[0].GetComponent<PlayerMovement>().enabled == true &&
        _Players[1].GetComponent<PlayerMovement>().enabled == true &&
        _Players[2].GetComponent<PlayerMovement>().enabled == true &&
        _Players[3].GetComponent<PlayerMovement>().enabled == true &&
        _Players[0].GetComponent<CharacterController2D>().enabled == true &&
        _Players[1].GetComponent<CharacterController2D>().enabled == true &&
        _Players[2].GetComponent<CharacterController2D>().enabled == true &&
        _Players[3].GetComponent<CharacterController2D>().enabled == true)
        {
            _Players[0].GetComponent<PlayerMovement>().enabled = false;
            _Players[1].GetComponent<PlayerMovement>().enabled = false;
            _Players[2].GetComponent<PlayerMovement>().enabled = false;
            _Players[3].GetComponent<PlayerMovement>().enabled = false;
            _Players[0].GetComponent<CharacterController2D>().enabled = false;
            _Players[1].GetComponent<CharacterController2D>().enabled = false;
            _Players[2].GetComponent<CharacterController2D>().enabled = false;
            _Players[3].GetComponent<CharacterController2D>().enabled = false;

            _buttons[0].GetComponent<Image>().sprite = _desactivateImage[0];
            _buttons[1].GetComponent<Image>().sprite = _desactivateImage[1];
            _buttons[2].GetComponent<Image>().sprite = _desactivateImage[2];
            _buttons[3].GetComponent<Image>().sprite = _desactivateImage[3];
            _buttons[4].GetComponent<Image>().sprite = _desactivateImage[4];
        }
        else
        {
            _Players[0].GetComponent<PlayerMovement>().enabled = true;
            _Players[1].GetComponent<PlayerMovement>().enabled = true;
            _Players[2].GetComponent<PlayerMovement>().enabled = true;
            _Players[3].GetComponent<PlayerMovement>().enabled = true;
            _Players[0].GetComponent<CharacterController2D>().enabled = true;
            _Players[1].GetComponent<CharacterController2D>().enabled = true;
            _Players[2].GetComponent<CharacterController2D>().enabled = true;
            _Players[3].GetComponent<CharacterController2D>().enabled = true;

            _buttons[0].GetComponent<Image>().sprite = _activeImage[0];
            _buttons[1].GetComponent<Image>().sprite = _activeImage[1];
            _buttons[2].GetComponent<Image>().sprite = _activeImage[2];
            _buttons[3].GetComponent<Image>().sprite = _activeImage[3];
            _buttons[4].GetComponent<Image>().sprite = _activeImage[4];
        }
    }

    public void SelectOldman()
    {
        _Players[3].GetComponent<PlayerMovement>().enabled = !_Players[3].GetComponent<PlayerMovement>().enabled;
        _Players[3].GetComponent<CharacterController2D>().enabled = !_Players[3].GetComponent<CharacterController2D>().enabled;
        if (_Players[3].GetComponent<PlayerMovement>().enabled)
        {
            _buttons[1].GetComponent<Image>().sprite = _activeImage[1];
        }
        else
        {
            _buttons[0].GetComponent<Image>().sprite = _desactivateImage[0];
            _buttons[1].GetComponent<Image>().sprite = _desactivateImage[1];
        }

        if (_Players[0].GetComponent<PlayerMovement>().enabled == true &&
        _Players[1].GetComponent<PlayerMovement>().enabled == true &&
        _Players[2].GetComponent<PlayerMovement>().enabled == true &&
        _Players[3].GetComponent<PlayerMovement>().enabled == true &&
        _Players[0].GetComponent<CharacterController2D>().enabled == true &&
        _Players[1].GetComponent<CharacterController2D>().enabled == true &&
        _Players[2].GetComponent<CharacterController2D>().enabled == true &&
        _Players[3].GetComponent<CharacterController2D>().enabled == true)
        {
            _buttons[0].GetComponent<Image>().sprite = _activeImage[0];
        }

    }

    public void SelectLittleGirl()
    {
        _Players[0].GetComponent<PlayerMovement>().enabled = !_Players[0].GetComponent<PlayerMovement>().enabled;
        _Players[0].GetComponent<CharacterController2D>().enabled = !_Players[0].GetComponent<CharacterController2D>().enabled;
        if (_Players[0].GetComponent<PlayerMovement>().enabled)
        {
            _buttons[4].GetComponent<Image>().sprite = _activeImage[4];
        }
        else
        {
            _buttons[0].GetComponent<Image>().sprite = _desactivateImage[0];
            _buttons[4].GetComponent<Image>().sprite = _desactivateImage[4];
        }

        if (_Players[0].GetComponent<PlayerMovement>().enabled == true &&
_Players[1].GetComponent<PlayerMovement>().enabled == true &&
_Players[2].GetComponent<PlayerMovement>().enabled == true &&
_Players[3].GetComponent<PlayerMovement>().enabled == true &&
_Players[0].GetComponent<CharacterController2D>().enabled == true &&
_Players[1].GetComponent<CharacterController2D>().enabled == true &&
_Players[2].GetComponent<CharacterController2D>().enabled == true &&
_Players[3].GetComponent<CharacterController2D>().enabled == true)
        {
            _buttons[0].GetComponent<Image>().sprite = _activeImage[0];
        }
    }

    public void SelectBoy()
    {
        _Players[1].GetComponent<PlayerMovement>().enabled = !_Players[1].GetComponent<PlayerMovement>().enabled;
        _Players[1].GetComponent<CharacterController2D>().enabled = !_Players[1].GetComponent<CharacterController2D>().enabled;
        if (_Players[1].GetComponent<PlayerMovement>().enabled)
        {
            _buttons[3].GetComponent<Image>().sprite = _activeImage[3];
        }
        else
        {
            _buttons[0].GetComponent<Image>().sprite = _desactivateImage[0];
            _buttons[3].GetComponent<Image>().sprite = _desactivateImage[3];
        }

        if (_Players[0].GetComponent<PlayerMovement>().enabled == true &&
_Players[1].GetComponent<PlayerMovement>().enabled == true &&
_Players[2].GetComponent<PlayerMovement>().enabled == true &&
_Players[3].GetComponent<PlayerMovement>().enabled == true &&
_Players[0].GetComponent<CharacterController2D>().enabled == true &&
_Players[1].GetComponent<CharacterController2D>().enabled == true &&
_Players[2].GetComponent<CharacterController2D>().enabled == true &&
_Players[3].GetComponent<CharacterController2D>().enabled == true)
        {
            _buttons[0].GetComponent<Image>().sprite = _activeImage[0];
        }
    }

    public void SelectMother()
    {
        _Players[2].GetComponent<PlayerMovement>().enabled = !_Players[2].GetComponent<PlayerMovement>().enabled;
        _Players[2].GetComponent<CharacterController2D>().enabled = !_Players[2].GetComponent<CharacterController2D>().enabled;
        if (_Players[2].GetComponent<PlayerMovement>().enabled)
        {
            _buttons[2].GetComponent<Image>().sprite = _activeImage[2];
        }
        else
        {
            _buttons[0].GetComponent<Image>().sprite = _desactivateImage[0];
            _buttons[2].GetComponent<Image>().sprite = _desactivateImage[2];
        }

        if (_Players[0].GetComponent<PlayerMovement>().enabled == true &&
_Players[1].GetComponent<PlayerMovement>().enabled == true &&
_Players[2].GetComponent<PlayerMovement>().enabled == true &&
_Players[3].GetComponent<PlayerMovement>().enabled == true &&
_Players[0].GetComponent<CharacterController2D>().enabled == true &&
_Players[1].GetComponent<CharacterController2D>().enabled == true &&
_Players[2].GetComponent<CharacterController2D>().enabled == true &&
_Players[3].GetComponent<CharacterController2D>().enabled == true)
        {
            _buttons[0].GetComponent<Image>().sprite = _activeImage[0];
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}
