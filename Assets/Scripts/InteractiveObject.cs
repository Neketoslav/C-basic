using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractiveObject : GameController
{

    public static bool _buff = false;
    public static bool _debuff = false;
    protected virtual void Interaction()
    {
        Debug.Log("pick up boost");
    }

    private void OnTriggerEnter(Collider other)
    {
        if (!other.CompareTag("Player"))
        {
            return;
        }
        Interaction();
        Destroy(gameObject);
    }
}
