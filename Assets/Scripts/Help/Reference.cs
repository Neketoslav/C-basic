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
        private GameObject endGame;
        private Canvas canvas;
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
        public Canvas Canvas
        {
            get
            {
                if (canvas == null)
                {
                    canvas = Object.FindObjectOfType<Canvas>();
                }
                return canvas;
            }
        }
        public GameObject EndGame
        {
            get
            {
                if (endGame == null)
                {
                    var gameObject = Resources.Load<GameObject>("winScreen");
                    endGame = Object.Instantiate(gameObject, Canvas.transform);
                }

                return endGame;
            }
        }
        public Camera MiniCamera
        {
            get
            {
                if (miniCamera == null)
                {
                    var gameObject = Resources.Load<Camera>("MiniMapCamera");
                    miniCamera = Object.Instantiate(gameObject);
                }
                return miniCamera;
            }
        }
    }
}

