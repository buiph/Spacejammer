using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour
{
    public static LevelManager Instance { get; private set; } // This is a singleton object

    public enum Scenes
    {
        StartGame,
        SciLightScene,
        GameOver,
        PersistenceScene
    }

    private void Awake()
    {
        if (Instance)
        {
            Destroy(gameObject);
        }
        else
        {
            Instance = this;
        }

        SceneManager.LoadScene("SplashScreen", LoadSceneMode.Additive);
    }
}

