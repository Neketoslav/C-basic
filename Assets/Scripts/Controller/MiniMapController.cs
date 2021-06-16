using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace RollABall
{
    internal class MiniMapController : IExecute
    {
        private Transform player;
        private Transform miniCamera;

        public MiniMapController(Transform _miniCameras, Transform _players)
        {
            player = _players;
            miniCamera = _miniCameras;
        }

        public void Execute()
        {
            //var newPosition = player.position;
            //newPosition.y = miniCamera.position.y;
            //miniCamera.position = newPosition;
            //miniCamera.rotation = Quaternion.Euler(90, player.eulerAngles.y, 0);
        }
    }

}

