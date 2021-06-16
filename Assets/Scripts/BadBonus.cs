using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace rollAball
{
    public class BadBonus : InteractiveObject, IRotation
    {
        private float _speedRotation = 20.0f;
        public delegate void TestDelegate();
        private event TestDelegate BadShake;

        protected override void Interaction()
        {
            base.Interaction();
            Debug.Log("deboost");
            InteractiveObject._debuff = true;
            EventShake EventShake1 = new EventShake();
            BadShake += EventShake1.AnimShake;
            BadShake();
        }

        public void Rotation()
        {
            transform.Rotate(Vector3.up * (Time.deltaTime * _speedRotation), Space.World);
        }
    }
}