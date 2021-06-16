using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace RollABall
{
    public class GameController : MonoBehaviour, IDisposable
    {
        private ListExecuteObject _interactiveObjects;
        private DisplayWin _displayWin;
        private int _countPoints;
        private PlayerController _playerController;
        private EndGame _endGame;
        private Reference reference;
        private CameraController _cameraController;
        private MiniMapController _miniMapController;
        private void Awake()
        {
            _interactiveObjects = new ListExecuteObject();

            reference = new Reference();

            PlayerBase player = null;
            player = reference.PlayerBall;



            _cameraController = new CameraController(player.transform, reference.MainCamera.transform);
            _interactiveObjects.AddExecuteObject(_cameraController);

            _miniMapController = new MiniMapController(reference.MiniCamera.transform, player.transform);
            _interactiveObjects.AddExecuteObject(_miniMapController);

            _playerController = new PlayerController(player);
            _interactiveObjects.AddExecuteObject(_playerController);

            _displayWin = new DisplayWin();

            foreach (var o in _interactiveObjects)
            {
                if (o is Points points)
                {
                    points.OnPointChange += AddPoint;
                }
                if (o is BadBonus badBonus)
                {
                    //подписка 
                }
                if (o is GoodBonus goodBonus)
                {
                    //подписка 
                }
            }
        }
        private void AddPoint(int value)
        {
            _countPoints += value;
            Debug.Log(_countPoints);
            _displayWin.Display(_countPoints);
            if (_countPoints == 3)
            {
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
                    //отписка
                }
                if (o is BadBonus badBonus)
                {
                    //отписка
                }
            }
        }
    }
}
