using UnityEngine.SceneManagement;
using UnityEngine;

public class LevelLoader : MonoBehaviour
{
    public void ReloadScene()
    {
        Scene thisScene = SceneManager.GetActiveScene();
        SceneManager.LoadScene(thisScene.buildIndex);
    }
}
