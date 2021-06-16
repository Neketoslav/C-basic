using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace RollABall
{
    public sealed class TestMyCreateObjectOnStart : MonoBehaviour
    {
        public GameObject _object;
        public int _count = 3;
        public int _offset = 5;

        private Transform _parent;

        private void Start()
        {
            CreateObject();
        }

        public void CreateObject()
        {
            _parent = new GameObject("Clones").transform;
            for (var i = 1; i <= _count; i++)
            {
                Instantiate(_object, new Vector3(i + _offset, 0, 0), Quaternion.identity, _parent);
            }
        }
    }
}

