using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace RollABall
{
    public class GameController : MonoBehaviour, IDisposable
    {
        private int _countPoints;
        private float playerCourentSpeed = 3f;

        private ListExecuteObject _interactiveObjects;

        private DisplayPoints _displayPoints;
        private WinScreen _winScreen;
        private Reference _reference;
        PlayerBase player = null;
        private PlayerController _playerController;
        private CameraController _cameraController;
        private MiniMapController _miniMapController;
        private void Awake()
        {
            _interactiveObjects = new ListExecuteObject();

            _reference = new Reference();

           
            player = _reference.PlayerBall;

            _cameraController = new CameraController(player.transform, _reference.MainCamera.transform);
            _interactiveObjects.AddExecuteObject(_cameraController);

            _miniMapController = new MiniMapController(player.transform, _reference.MiniCamera.transform);
            _interactiveObjects.AddExecuteObject(_miniMapController);

            _playerController = new PlayerController(player);
            _interactiveObjects.AddExecuteObject(_playerController);

            _displayPoints = new DisplayPoints();
            _winScreen = new WinScreen(_reference.EndGame);

            foreach (var o in _interactiveObjects)
            {
                if (o is Points points)
                {
                    points.OnPointChange += AddPoint;
                }
                if (o is BadBonus badBonus)
                {
                    badBonus.playerPickUpDebuff += SpeedDebuff;
                }
                if (o is GoodBonus goodBonus)
                {
                    goodBonus.playerPickUpBuff += SpeedBuff;
                }
            }
        }

        private void SpeedDebuff(float value)
        {
            playerCourentSpeed -= value;
            Debug.Log(playerCourentSpeed);
            player.Speed = playerCourentSpeed;
            Invoke("TimeBuff", 5f);
        }

        private void SpeedBuff(float value)
        {
            playerCourentSpeed += value;
            Debug.Log(playerCourentSpeed);
            player.Speed = playerCourentSpeed;
            Invoke("TimeBuff", 5f);
        }

        private void TimeBuff()
        {
            playerCourentSpeed = 3f;
            player.Speed = playerCourentSpeed;
            Debug.Log(playerCourentSpeed);
        }

        private void AddPoint(int value)
        {
            _countPoints += value;
            Debug.Log(_countPoints);
            _displayPoints.Display(_countPoints);
            if (_countPoints == 14)
            {
                _winScreen.Win();
                Debug.Log("win");
            }
        }

        private void Update()
        {
            for (var i = 0; i < _interactiveObjects.Length; i++)
            {
                var interactiveObject = _interactiveObjects[i];
                if (interactiveObject == null)
                {
                    continue;
                }
                interactiveObject.Execute();
            }
        }

        public void Disposable()
        {
            foreach (var o in _interactiveObjects)
            {
                if (o is Points points)
                {
                    points.OnPointChange -= AddPoint;
                }
                if (o is GoodBonus goodBonus)
                {
                    goodBonus.playerPickUpBuff -= SpeedBuff;
                }
                if (o is BadBonus badBonus)
                {
                    badBonus.playerPickUpDebuff += SpeedDebuff;
                }
            }
        }
    }
}
