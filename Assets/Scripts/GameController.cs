using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace RollABall
{
    public class GameController : MonoBehaviour, IDisposable
    {
        [SerializeField] Data _data;
        private ListExecuteObject _interactiveObjects;
        private DisplayWin _displayWin;
        private int _countPoints;
        private PlayerController _playerController;
        private EndGame _endGame;
        private void Awake()
        {
            //_playerController = new PlayerController(_data._playerBase);
            //AddExecuteObject

            _interactiveObjects = new ListExecuteObject();
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
