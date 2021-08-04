using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace RollABall
{
    public class Map : MonoBehaviour
    {
        private Transform _player;
        public void Start()
        {
            var main = Camera.main;
            _player = main.transform;
        }
    }

}
