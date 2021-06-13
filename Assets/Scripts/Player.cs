using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : GameController
{
    private Vector3 _direction;
    private float _playerSpeed = 5.0f;

    public void move()
    {
        _direction.x = Input.GetAxis("Horizontal");
        _direction.z = Input.GetAxis("Vertical");
        var speed = _direction * _playerSpeed  * Time.deltaTime;
        transform.Translate(speed);
    }
    private void FixedUpdate()
    {
        if (InteractiveObject._buff == true)
            StartCoroutine(Boost());
        if (InteractiveObject._debuff == true)
            StartCoroutine(Deboost());
        move();
    }

        IEnumerator Boost()
        {
            yield return new WaitForSeconds(0.0f);
            _playerSpeed *= 2;
            InteractiveObject._buff = false;
            Debug.Log("boost is work");
            yield return new WaitForSeconds(5.0f);
            _playerSpeed /= 2;
            Debug.Log("boost is over");
        }
        IEnumerator Deboost()
        {
            yield return new WaitForSeconds(0.0f);
            _playerSpeed /= 2;
            InteractiveObject._debuff = false;
            Debug.Log("deboost is work");
            yield return new WaitForSeconds(5.0f);
            _playerSpeed /= 2;
            Debug.Log("deboost is over");
    }
}
