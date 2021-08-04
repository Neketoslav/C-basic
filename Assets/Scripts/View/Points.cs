using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace RollABall
{
    public class Points : InteractiveObject, IRotation, IExecute
    {
        private float _speedRotation = 10.0f;
        public event Action<int> OnPointChange = delegate (int i) { };


        //private readonly SaveDataRepository saveDataRepository;
        //private readonly KeyCode saveBonus = KeyCode.C;
        //private readonly KeyCode loadBonus = KeyCode.V;

        protected override void Interaction()
        {
            OnPointChange.Invoke(1);
        }
        public override void Execute()
        {
            if (!isInteractable) { return; }
            Rotation();
            //if (Input.GetKeyDown(saveBonus))
            //{
            //    saveDataRepository.SaveBonus(isInteractable);
            //}
            //if (Input.GetKeyDown(loadBonus))
            //{
            //    saveDataRepository.LoadBonus(isInteractable);
            //}
        }
        public void Rotation()
        {
            transform.Rotate(Vector3.up * (Time.deltaTime * _speedRotation));
        }
    }
}
