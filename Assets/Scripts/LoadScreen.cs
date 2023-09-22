using System.Collections;
using JetBrains.Annotations;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LoadScreen : MonoBehaviour
{
    [NotNull] public string sceneToLoad;
    
    [NotNull] public GameObject LoadingPanel;

    public Slider bar;

    

    public void Load()
    {
        LoadingPanel.SetActive(true);
        StartCoroutine(LoadAsync());
    }

    private IEnumerator LoadAsync()
    {
        AsyncOperation asyncOperation = SceneManager.LoadSceneAsync(sceneToLoad);
        while (!asyncOperation.isDone)
        {
            bar.value = asyncOperation.progress;
            yield return null;
        }
    }
}
