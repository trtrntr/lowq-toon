using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using Toon.Extend;

namespace Toon
{
    public class SceneLoading : MonoBehaviour
    {
        [SerializeField]
        GameObject panel;

        [SerializeField]
        Slider slider;

        [SerializeField]
        Button button;

        [SerializeField]
        constant.SceneIndex index;

        public void LoadingNext()
        {
            panel.SetActive(true);
            StartCoroutine(LoadingScene());
        }

        IEnumerator LoadingScene()
        {
            var async = SceneManager.LoadSceneAsync(((int)index));
            while (!async.isDone)
            {
                slider.value = async.progress;
                yield return null;
            }
        }
    }
}