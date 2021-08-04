﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace RollABall
{
    public class Buffs : Player
    {
        public static float _buffSpeed = 1f;
        public void SpeedBoost()
        {
            if (InteractiveObject._buff == true)
                StartCoroutine(Boosts());
            if (InteractiveObject._debuff == true)
                StartCoroutine(Deboosts());
        }
        public IEnumerator Boosts()
        {
            yield return new WaitForSeconds(0.0f);
            _buffSpeed = 2f;
            InteractiveObject._buff = false;
            Debug.Log("boost is work");
            yield return new WaitForSeconds(5.0f);
            _buffSpeed = 1f;
            Debug.Log("boost is over");
        }
        public IEnumerator Deboosts()
        {
            yield return new WaitForSeconds(0.0f);
            _buffSpeed = 0.5f;
            InteractiveObject._debuff = false;
            Debug.Log("deboost is work");
            yield return new WaitForSeconds(5.0f);
            _buffSpeed = 1f;
            Debug.Log("deboost is over");
        }

    }
}
