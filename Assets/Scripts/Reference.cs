using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace RollABall
{
    public class Reference
    {
        private Camera miniCamera;
        private PlayerBall playerBall;
        private Camera mainCamera;
        public PlayerBall PlayerBall
        {
            get
            {
                if (playerBall == null)
                {
                    var gameObject = Resources.Load<PlayerBall>("Player");
                    playerBall = Object.Instantiate(gameObject);
                }

                return playerBall;
            }

        }
        public Camera MainCamera
        {
            get
            {
                if (mainCamera == null)
                {
                    mainCamera = Camera.main;
                }
                return mainCamera;
            }
        }
        public Camera MiniCamera
        {
            get
            {
                if (miniCamera == null)
                {
                    miniCamera = Camera.main;
                }
                return miniCamera;
            }
        }
    }
}

