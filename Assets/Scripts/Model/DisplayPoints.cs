using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

namespace RollABall
{
    public sealed class DisplayPoints
    {
        private Text _text;      
        public DisplayPoints()
        {
            _text = Object.FindObjectOfType<Text>();
        }
        
        public void Display(int value)
        {
            _text.text = $"Вы набрали {value}";
            
        }
    }
}
