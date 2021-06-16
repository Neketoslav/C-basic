using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace RollABall
{
    [Serializable]
    public class SavedData
    {
        public Vector3Serializable Position;
        public bool isEnabled;
        public override string ToString() => $"Position {Position}";
    }
    [Serializable]
    public struct Vector3Serializable
    {
        public float x;
        public float y;
        public float z;

        private Vector3Serializable(float _x, float _y, float _z)
        {
            x = _x;
            y = _y;
            z = _z;
        }
        public static implicit operator Vector3(Vector3Serializable value)
        {
            return new Vector3(value.x, value.y, value.z);
        }
        public static implicit operator Vector3Serializable(Vector3 value)
        {
            return new Vector3Serializable(value.x, value.y, value.z);
        }
        public override string ToString() => $" (X = {x} Y = {y} Z = {z})";
    }



}
