using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

namespace RollABall
{
    public class TestWindow : EditorWindow
    {
        public GameObject _gameObject;
        public string _nameObject = "Test";
        public int _x = 0;
        public int _y = 0;
        public int _z = 0;
        private void OnGUI()
        {
            GUILayout.Label("Settings");
            _gameObject = EditorGUILayout.ObjectField("Object", _gameObject, typeof(GameObject), true) as GameObject;

            _nameObject = EditorGUILayout.TextField("Object name", _nameObject);

            _x = EditorGUILayout.IntField("x position", _x);

            _y = EditorGUILayout.IntField("y position", _y);

            _z = EditorGUILayout.IntField("z position", _z);

            var button = GUILayout.Button("Create Object");
            if (button)
            {
                if (_gameObject)
                {               
                    Vector3 _position = new Vector3(_x, _y, _z);
                    GameObject _obj = Instantiate(_gameObject, _position, Quaternion.identity);
                    _obj.name = _nameObject;
                }
            }
        }
    }
}
