using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.Assertions;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    [SerializeField] internal SettingsData settingsData;
    PlayerInputAction inputAction;

    public GameObject pausePanel;
    internal bool paused;

    [SerializeField] private TextMeshProUGUI _timerDisplay;
    [SerializeField] private TextMeshProUGUI _countdownDisplay;
    public float matchLength;
    private float _matchTimeStamp;
    private float _countdownTimeStamp;
    private bool _countingDown;

    [SerializeField] private GameObject _replayPanel;
    [SerializeField] private TextMeshProUGUI _winnerText;

    [SerializeField] private TextMeshProUGUI[] _scoreDisplay = new TextMeshProUGUI[2]; // [Left, Right]
    [SerializeField] private GameObject[] _goals = new GameObject[2]; // [Left, Right]
    [SerializeField] private Transform[] _startPos = new Transform[3]; // [Left, Right, Puck]
    [SerializeField] private GameObject[] _players = new GameObject[2]; // [Red, Blue]
    [SerializeField] private GameObject _puck;
    int scoreLeft;
    int scoreRight;

    void Awake()
    {
        inputAction = new PlayerInputAction();
        inputAction.GameControls.Pause.performed += _ => Pause();
    }

    void Start()
    {
        // Assert objects not null
        Assert.IsNotNull( _scoreDisplay[0] );
        Assert.IsNotNull( _scoreDisplay[1] );
        Assert.IsNotNull( _goals[0] );
        Assert.IsNotNull( _goals[0] );
        Assert.IsNotNull( _startPos[0] );
        Assert.IsNotNull( _startPos[1] );
        Assert.IsNotNull( _startPos[2] );
        Assert.IsNotNull( _players[0] );
        Assert.IsNotNull( _players[1] );
        Assert.IsNotNull( _puck );

        // Assert UI not null
        Assert.IsNotNull( _replayPanel );
        Assert.IsNotNull( _winnerText );
        Assert.IsNotNull( _timerDisplay );
        Assert.IsNotNull( _countdownDisplay );

        // Events subscription
        _goals[0].GetComponent<GoalsScript>().OnRightGainPoint += UpdateScoreRight;
        _goals[0].GetComponent<GoalsScript>().OnRightGainPoint += AwardPuckLeft;
        _goals[1].GetComponent<GoalsScript>().OnLeftGainPoint += UpdateScoreLeft;
        _goals[1].GetComponent<GoalsScript>().OnLeftGainPoint += AwardPuckRight;
        
        paused = false;
        _players[0].transform.position = _startPos[0].position;
        _players[1].transform.position = _startPos[1].position;
        _puck.transform.position = _startPos[2].position;

        _replayPanel.SetActive(false);
        _countdownDisplay.gameObject.SetActive(true);

        _countdownTimeStamp = Time.time; // Start the countdown
        _countingDown = false;
        StartCoundown();
    }

    void Update()
    {
        // Counting down
        if (_countingDown)
        {
            if (Time.time < _countdownTimeStamp + 2.99f)
            {
                _countdownDisplay.text = ((int)((3.99f - (Time.time - _countdownTimeStamp)) % 60)).ToString(); 
            }
            else
            {
                GameStart();
                _countingDown = false;
                _countdownDisplay.gameObject.SetActive(false);
            }
        }
        else // After the countdown
        {
            float remainingTime = _matchTimeStamp + matchLength - Time.time;
            _timerDisplay.text = remainingTime.ToString("f0");

            if (remainingTime <= 0)
            {
                GameEnd();
            }
        }        
    }

    /// <summary>
    /// Updates score for the left player
    /// </summary>
    /// <param name="score"></param>
    void UpdateScoreLeft(int score)
    {
        scoreLeft += score;
        UpdateScoreDisplay();
    }

    /// <summary>
    /// Update score for the right player
    /// </summary>
    /// <param name="score"></param>
    void UpdateScoreRight(int score)
    {
        scoreRight += score;
        UpdateScoreDisplay();
    }

    /// <summary>
    /// Updates the score display
    /// </summary>
    void UpdateScoreDisplay()
    {
        _scoreDisplay[0].text = scoreLeft.ToString();
        _scoreDisplay[1].text = scoreRight.ToString();
    }

    /// <summary>
    /// Give puck to left player
    /// </summary>
    /// <param name="obj"></param>
    void AwardPuckLeft(int obj)
    {
        ResetPlayerPos();
        _puck.transform.position = _players[0].transform.position;
    }

    /// <summary>
    /// Give puck to right player
    /// </summary>
    /// <param name="obj"></param>
    void AwardPuckRight(int obj)
    {
        ResetPlayerPos();
        _puck.transform.position = _players[1].transform.position;
    }

    /// <summary>
    /// Resets the position of both players
    /// </summary>
    void ResetPlayerPos()
    {
        _players[0].transform.position = _startPos[0].position;
        _players[1].transform.position = _startPos[1].position;
    }

    /// <summary>
    /// Starts the process of counting down the the game's start
    /// </summary>
    public void StartCoundown()
    {
        // Set timescale to the value saved once, on startup
        Time.timeScale = settingsData.gameSpeed;

        // Set cursor
        Cursor.visible = false;

        _countingDown = true;
        _countdownDisplay.gameObject.SetActive(true);
        _replayPanel.SetActive(false);

        // Lock player movement while counting down
        _players[0].GetComponent<PlayerControls>().locked = true;
        _players[0].GetComponent<PlayerControls>().holdingPuck = false;
        _players[0].GetComponent<PlayerControls>().powerGauge.SetActive(false);
        _players[1].GetComponent<PlayerControls>().locked = true;
        _players[1].GetComponent<PlayerControls>().holdingPuck = false;
        _players[1].GetComponent<PlayerControls>().powerGauge.SetActive(false);

        // Reset player and puck states
        ResetPlayerPos();
        _puck.GetComponent<Puck>().velocity = Vector3.zero;
        _puck.transform.position = _startPos[2].position;

        // Reset scores
        scoreLeft = 0;
        scoreRight = 0;
        UpdateScoreDisplay();

        _countdownTimeStamp = Time.time;
    }

    /// <summary>
    /// Starts the game
    /// </summary>
    public void GameStart()
    {
        _replayPanel.SetActive(false);

        // Set timescale to the value saved
        Time.timeScale = settingsData.gameSpeed;

        // Unlocks movement
        _players[0].GetComponent<PlayerControls>().locked = false;
        _players[1].GetComponent<PlayerControls>().locked = false;

        // Launches the puck
        float x = UnityEngine.Random.Range(0, 2) == 0 ? -1 : 1;
        float z = UnityEngine.Random.Range(0, 2) == 0 ? -1 : 1;
        _puck.GetComponent<Puck>().Launch(x, z, 10);

        // Start the timer
        _matchTimeStamp = Time.time;
    }

    /// <summary>
    /// End the current match
    /// </summary>
    void GameEnd()
    {
        Time.timeScale = 0;

        // Set cursor
        Cursor.visible = true;

        _replayPanel.SetActive(true);
        if (scoreLeft < scoreRight)
        {
            _winnerText.text = "Blue Wins!";
        }
        else if (scoreLeft > scoreRight)
        {
            _winnerText.text = "Red Wins!";
        }
        else
        {
            _winnerText.text = "Draw!";
        }
    }

    /// <summary>
    /// Pauses the game and display the pause screeen
    /// </summary>
    public void Pause()
    {
        AudioManager.Instance.Play("ButtonClick");

        if (!paused)
        {
            // Set cursor
            Cursor.visible = true;

            pausePanel.gameObject.SetActive(true);
            Time.timeScale = 0;
            paused = true;
        }
        else
        {
            // Set cursor
            Cursor.visible = false;

            pausePanel.gameObject.SetActive(false);
            Time.timeScale = settingsData.gameSpeed;
            paused = false;
        }
    }

    /// <summary>
    /// Quits the game
    /// </summary>
    public void Quit()
    {
        AudioManager.Instance.Play("ButtonClick");
        Application.Quit();
    }

    private void OnEnable()
    {
        inputAction.Enable();
    }

    private void OnDisable()
    {
        inputAction.Disable();
    }
}
