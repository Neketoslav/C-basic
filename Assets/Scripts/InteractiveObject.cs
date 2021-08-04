using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace RollABall
{
    public abstract class InteractiveObject : MonoBehaviour, IExecute
    {
        public static bool _buff = false;
        public static bool _debuff = false;
        
        private bool _isInteractable;


        protected bool isInteractable
        {
            get { return _isInteractable; }
            private set
            {
                _isInteractable = value;
                GetComponent<Renderer>().enabled = _isInteractable;
                GetComponent<Collider>().enabled = _isInteractable;
            }
        }

        public abstract void Execute();

        protected abstract void Interaction();

        private void OnTriggerEnter(Collider other)
        {
            if (other.CompareTag("Player"))
            {
                Interaction();
                isInteractable = false;
            }
            return;

        }

    }
}