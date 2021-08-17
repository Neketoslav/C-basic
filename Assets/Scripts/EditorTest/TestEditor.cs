using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace RollABall
{
    public sealed class TestEditor : MonoBehaviour
    {
        [ExecuteInEditMode]

        [Header("X")]
        [SerializeField] private int x;

        [Header("Y")]
        [SerializeField] private int y;

        [Header("Z")]
        [SerializeField] private int z;

        [Header("Object")]
        [SerializeField] private GameObject _gameObject;


        [Obsolete("error")]
        private void TestObsolete()
        {
        }

    }

}

