using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace RollABall
{
    public class BadBonus : InteractiveObject, IRotation
    {
        private float _speedRotation = 30.0f;
        public delegate void DebuffSpeed(float i);
        public event DebuffSpeed playerPickUpDebuff;

        protected override void Interaction()
        {
            playerPickUpDebuff.Invoke(2f);
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