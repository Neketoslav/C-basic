using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace RollABall
{
    public class WinScreen
    {
        private GameObject _screen;
        public WinScreen(GameObject gameObject)
        {
           _screen = gameObject;
           _screen.SetActive(false);
        }
        public void Win()
        {
            _screen.SetActive(true);
        }
    }
}

