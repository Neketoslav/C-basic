using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class DisplayWin    
{
    internal static int _point = 0;
    private static TMP_Text _score;

    private void Awake()
    {
        _score = Object.FindObjectOfType<TMP_Text>();
        _score.text = "Score: " + _point.ToString();
    }
    public static void Point()
    {
        _point += 1;
        _score.text = "Score: " + _point.ToString();
        if (_point == 3)
        {
            DisplayWin.Score();
        }
    }
    public static void Score()
    {
          Debug.Log("win");
    }

}
