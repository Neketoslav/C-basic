using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

namespace RollABall
{
    public class RestartLevel : MonoBehaviour
    {
        private Button _button;

        private void Start()
        {
            _button = gameObject.GetComponent<Button>();
            _button.onClick.AddListener(RestartButton);
        }
        public void RestartButton()
        {
            SceneManager.LoadScene("SampleScene");
        }
    }
}
