using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
namespace rollAball
{
    public class DisplayWin
    {
        internal static int _point = 0;
        private static TMP_Text _score;


        public DisplayWin()
        {
            _score = Object.FindObjectOfType<TMP_Text>();
            _score.text = "Score: " + _point.ToString();
        }
        public static void Point()
        {
            _point++;
            _score.text = "Score: " + _point;
        }
    }
}
