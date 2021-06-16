using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

namespace RollABall
{
    [CustomEditor(typeof(TestMyCreateObjectOnStart))]
    public class TestExtension : UnityEditor.Editor
    {
        public override void OnInspectorGUI()
        {
            TestMyCreateObjectOnStart _test = (TestMyCreateObjectOnStart)target;

            _test._count = EditorGUILayout.IntSlider(_test._count, 1, 50);
            _test._offset = EditorGUILayout.IntSlider(_test._offset, 1, 5);

            _test._object = EditorGUILayout.ObjectField("Object", _test._object, typeof(GameObject), false) as GameObject;

            var clickOnButton = GUILayout.Button("Create object", EditorStyles.miniButtonLeft);

            if (clickOnButton)
            {
                _test.CreateObject();
            }
        }
    }
}
