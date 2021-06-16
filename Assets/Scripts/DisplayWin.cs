using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

namespace RollABall
{
    public sealed class DisplayWin
    {
        private Text _text;

        public DisplayWin()
        {
            _text = Object.FindObjectOfType<Text>();
        }
        
        public void Display(int value)
        {
            _text.text = $"Вы набрали {value}";
        }
    }
}
