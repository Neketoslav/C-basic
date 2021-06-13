using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public sealed class GoodBonus : InteractiveObject, IRotation
{
    private float _speedRotation = 10.0f;

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

    //public delegate void SpeedBonus();
    //public SpeedBonus SpeedBuffPlayer;
}
