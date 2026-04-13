using UnityEngine.SceneManagement;
using UnityEngine;
using System.Collections;

public class SceneLoader : MonoBehaviour
{

    public void LoadScene(int lvlIndex)
    {
        StartCoroutine(LoadSceneAsynchronously(lvlIndex));
    }

    IEnumerator LoadSceneAsynchronously(int lvlIndex)
    {
        AsyncOperation operation = SceneManager.LoadSceneAsync(lvlIndex);
        while (!operation.isDone)
        {
            Debug.Log(operation.progress);
            yield return null;
        }
    }
}
