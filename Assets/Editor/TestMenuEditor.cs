using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

namespace RollABall
{
    public class TestMenuEditor
    {
        [MenuItem("MyMenu/Menu")]
        private static void Menu()
        {
            EditorWindow.GetWindow(typeof(TestWindow), false, "Create Object");
        }
    }
}

