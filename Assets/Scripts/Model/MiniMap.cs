using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace RollABall
{
    internal class MiniMap : MonoBehaviour, IMap
    {
        private readonly Transform miniCamera;
        private readonly Transform player;
        private Transform _player;

        public MiniMap(Transform _miniCamera, Transform _player)
        {
            miniCamera = _miniCamera;
            player = _player;
        }

        public void Map()
        {
            var main = Camera.main;
            miniCamera.parent = null;
            miniCamera.rotation = Quaternion.Euler(90.0f, 0, 0);
            miniCamera.position = player.position + new Vector3(0, 5.0f, 0);

            var rt = Resources.Load<RenderTexture>("MiniMap/map");

            var component = miniCamera.GetComponent<Camera>();
            component.targetTexture = rt;
            component.depth = --main.depth;
        }
    }
}