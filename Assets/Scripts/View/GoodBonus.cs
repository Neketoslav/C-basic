using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace RollABall
{
    public sealed class GoodBonus : InteractiveObject, IRotation, IExecute
    {
        private float _speedRotation = 10.0f;

        protected override void Interaction()
        {
            Debug.Log("boost");
            InteractiveObject._buff = true;
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
