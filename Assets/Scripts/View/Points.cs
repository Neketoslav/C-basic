using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace RollABall
{
    public class Points : InteractiveObject, IRotation, IExecute
    {
        private float _speedRotation = 20.0f;
        public event Action<int> OnPointChange = delegate (int i) { };

        protected override void Interaction()
        {
            OnPointChange.Invoke(1);
        }
        public override void Execute()
        {
            Rotation();
        }
        public void Rotation()
        {
            transform.Rotate(Vector3.up * (Time.deltaTime * _speedRotation));
        }
    }
}
