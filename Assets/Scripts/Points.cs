using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Points : InteractiveObject, IRotation
{
    private float _speedRotation = 10.0f;

    protected override void Interaction()
    {
        base.Interaction();
       // DisplayWin.Point();
    }

    public void Rotation()
    {
        transform.Rotate(Vector3.up * (Time.deltaTime * _speedRotation));
    }
}
