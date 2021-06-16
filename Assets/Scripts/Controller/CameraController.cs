using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace RollABall
{
    public sealed class CameraController : IExecute
    {
        private Transform player;
        private Transform mainCamera;
        private Vector3 offset;

        public CameraController(Transform _player, Transform _mainCamera)
        {
            player = _player;
            mainCamera = _mainCamera;
            mainCamera.LookAt(player);
            offset = mainCamera.position - player.position;
        }

        public void Execute()
        {
            mainCamera.position = player.position + offset;
        }
    }
}

