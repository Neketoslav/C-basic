using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace RollABall
{
    public sealed class GoodBonus : InteractiveObject, IRotation, IExecute
    {
        private float _speedRotation = 30.0f;
        public delegate void BuffSpeed(float i);
        public event BuffSpeed playerPickUpBuff;
        protected override void Interaction()
        {
            playerPickUpBuff.Invoke(7.0f);
        }

        public override void Execute()
        {          
            Rotation();
        }

        public void Rotation()
        {
            transform.Rotate(Vector3.up * (Time.deltaTime * _speedRotation), Space.World);
        }

    }
}
