using System;
using UnityEngine;
using UnityEngine.Assertions;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class TitleSceneManager : MonoBehaviour
{
    [SerializeField] private Button _playButton;
    [SerializeField] private Button _quitButton;

    void Start()
    {
        Assert.IsNotNull( _playButton );
        Assert.IsNotNull( _quitButton );

        _playButton.onClick.AddListener(delegate{ LoadGameScene(); });
        _quitButton.onClick.AddListener(delegate{ Quit(); });
    }

    /// <summary>
    /// Load GameScene to start the game
    /// </summary>
    public void LoadGameScene()
    {
        AudioManager.Instance.Play("ButtonClick");
        SceneManager.LoadScene("GameScene", LoadSceneMode.Additive);
        SceneManager.UnloadSceneAsync("SplashScreen");
    }

    /// <summary>
    /// Quits the game
    /// </summary>
    public void Quit()
    {
        AudioManager.Instance.Play("ButtonClick");
        Application.Quit();
    }
}
