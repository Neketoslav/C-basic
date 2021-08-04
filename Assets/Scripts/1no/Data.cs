using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
namespace RollABall
{
    [CreateAssetMenu(fileName = "Data", menuName = "Data/Data")]
    public sealed class Data : ScriptableObject
    {
        [SerializeField] private string _playerDataPath;
        private PlayerData _player;
        private GameObject _winScreen;
        private Canvas _canvas;
        public PlayerData Player
        {
            get
            {
                if (_player == null)
                {
                    _player = Load<PlayerData>("Data/" + _playerDataPath);
                }
                return _player;
            }
        }
        public Canvas Canvas
        {
            get
            {
                if (_canvas == null)
                {
                    _canvas = Object.FindObjectOfType<Canvas>();
                }
                return _canvas;
            }
        }
        public GameObject EndGame
        {
            get
            {
                if (_winScreen == null)
                {
                    var gameObject = Resources.Load<GameObject>("WinScreen");
                    _winScreen = Object.Instantiate(gameObject, Canvas.transform);
                }

                return _winScreen;
            }
        }

        private T Load<T>(string resourcesPath) where T : Object =>
        Resources.Load<T>(Path.ChangeExtension(resourcesPath, null));
    }
}
