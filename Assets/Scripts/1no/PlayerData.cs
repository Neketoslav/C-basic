using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

namespace RollABall
{
    [CreateAssetMenu(fileName = "PlayerSettings", menuName = "Data/Player/PlayerSettings")]
    public class PlayerData: ScriptableObject
    {
        [SerializeField, Range(0, 100)] private float _speed;
        [SerializeField] private Vector3 _position;
        public float Speed => _speed;
        public Vector3 Position => _position;
    }
}