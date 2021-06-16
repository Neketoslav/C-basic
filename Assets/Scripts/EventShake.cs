using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace rollAball
{
    public class EventShake
    {
        Animator _animator;
        
        public void AnimShake()
        {
            _animator = Camera.main.GetComponent<Animator>();
            _animator.SetTrigger("shake");
            Debug.Log("Shake this world");
        }
    }

}