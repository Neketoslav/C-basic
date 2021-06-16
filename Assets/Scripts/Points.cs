using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace rollAball
{
    public class Points : InteractiveObject, IRotation
    {
        private float _speedRotation = 10.0f;
        private int score = 0;


        protected override void Interaction()
        {
            base.Interaction();
        }

        public void Rotation()
        {
            transform.Rotate(Vector3.up * (Time.deltaTime * _speedRotation));
        }
    }
}
