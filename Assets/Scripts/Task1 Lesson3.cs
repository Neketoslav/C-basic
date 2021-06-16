using System.Collections;
using System.Collections.Generic;
using System.Data;
using UnityEngine;

public class Task1Lesson3 : MonoBehaviour
{
    [SerializeField] GameObject _test;
    void Start()
    {
        if (_test == null)
            throw new DataException("_test not found"); 
    }

}
