using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace RollABall
{
    public class BadBonus : InteractiveObject, IRotation
    {
        private float _speedRotation = 20.0f;

        protected override void Interaction()
        {
            Debug.Log("deboost");
            InteractiveObject._debuff = true;
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