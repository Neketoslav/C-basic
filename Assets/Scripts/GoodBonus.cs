using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace rollAball
{
    public sealed class GoodBonus : InteractiveObject, IRotation, IDisposable
    {
        private float _speedRotation = 10.0f;

        public void Disposable()
        {
            throw new System.NotImplementedException();
        }

        protected override void Interaction()
        {
            base.Interaction();
            Debug.Log("boost");
            InteractiveObject._buff = true;
        }

        void IRotation.Rotation()
        {
            transform.Rotate(Vector3.up * (Time.deltaTime * _speedRotation));
        }

    }
}
