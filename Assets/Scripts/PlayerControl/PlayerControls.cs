using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Assertions;
using UnityEngine.UI;

public class PlayerControls : MonoBehaviour
{
    public bool playerLeft;

    PlayerInputAction inputAction;
    Rigidbody rb;

    internal float xVal, yVal, yValShoot;
    [SerializeField] private float _movementSpeed;
    private float _dashSpeed;
    Vector2 movementInput;
    Vector2 shootInput;
    
    public Transform puckPos;
    internal bool holdingPuck;
    internal bool locked;

    [SerializeField] internal GameObject powerGauge;
    [SerializeField] internal Image powerGaugeFill;
    private float _powerTimeStamp;
    private float _powerScaling;
    private float _minimumPower;

    public event Action<float, float, float> OnLaunch;

    void Awake()
    {
        inputAction = new PlayerInputAction();
        if (playerLeft)
        {
            inputAction.PlayerL.Move.performed += ctx => movementInput = ctx.ReadValue<Vector2>();
            inputAction.PlayerL.ShootDir.performed += ctx => shootInput = ctx.ReadValue<Vector2>();
            inputAction.PlayerL.Shoot.performed += ctx => Shoot();
            inputAction.PlayerL.Dash.performed += ctx => Dash();
        }
        else
        {
            inputAction.PlayerR.Move.performed += ctx => movementInput = ctx.ReadValue<Vector2>();
            inputAction.PlayerR.ShootDir.performed += ctx => shootInput = ctx.ReadValue<Vector2>();
            inputAction.PlayerR.Shoot.performed += ctx => Shoot();
            inputAction.PlayerR.Dash.performed += ctx => Dash();
        }
    }

    void Start()
    {
        // Assert UI not null
        Assert.IsNotNull( powerGauge );
        Assert.IsNotNull( powerGaugeFill );

        powerGauge.SetActive(false);

        rb = GetComponent<Rigidbody>();
        locked = false;
        holdingPuck = false;

        _powerScaling = 20;
        _minimumPower = 8;
        _dashSpeed = 1;
    }

    void Update()
    {
        if (!locked) // Accepts movement input only when you dont have the puck
        {
            xVal = movementInput.x;
            yVal = movementInput.y;
            yValShoot = 0;
        }

        if (holdingPuck) // Accepts shoot input only when you have the puck
        {
            yValShoot = shootInput.y;
            xVal = 0;
            yVal = 0;
        }
    }

    void FixedUpdate()
    {
        Vector3 moveDir = new Vector3(xVal, 0, yVal);
        rb.MovePosition(transform.position + moveDir * Time.deltaTime * _movementSpeed * _dashSpeed);

        // Drains the power gauge over time
        powerGaugeFill.fillAmount = 1 - (Time.time - _powerTimeStamp);
    }

    /// <summary>
    /// Shoots the puck in a direction
    /// </summary>
    private void Shoot()
    {
        if (holdingPuck)
        {
            if (playerLeft)
            {
                LaunchPuck(1, yValShoot, _powerScaling - ((Time.time - _powerTimeStamp) * 10));
            }
            else
            {
                LaunchPuck(-1, yValShoot, _powerScaling - ((Time.time - _powerTimeStamp) * 10));
            }
        }
    }

    /// <summary>
    /// Performs a dash
    /// </summary>
    private void Dash()
    {
        if (!locked && (xVal != 0 || yVal != 0))
        {
            AudioManager.Instance.Play("Dash");
            _dashSpeed = 3;
            StartCoroutine(DashTimeOut());
        }
    }

    private void OnCollisionEnter(Collision other)
    {
        if (other.transform.CompareTag("Puck"))
        {
            AudioManager.Instance.Play("Catch");
            ReceivePuck(other.gameObject);

            StartCoroutine(TimeoutLaunchPuck());
        }
    }

    /// <summary>
    /// Receive puck and set its position to in front of this player
    /// </summary>
    /// <param name="received"></param>
    internal void ReceivePuck(GameObject received)
    {
        holdingPuck = true;
        _powerTimeStamp = Time.time;

        received.transform.SetPositionAndRotation(puckPos.position, received.transform.rotation); // Set puck position to in front of this player

        powerGauge.SetActive(true); // Show power gauge when holding the puck
        powerGauge.transform.position = Camera.main.WorldToScreenPoint(transform.position); // power gauge shows on top of player no matter where they are
    }

    /// <summary>
    /// Invoke event to launch the puck
    /// </summary>
    /// <param name="x"></param>
    /// <param name="z"></param>
    /// <param name="power"></param>
    internal void LaunchPuck(float x, float z, float power)
    {
        if (holdingPuck)
        {
            AudioManager.Instance.Play("Shoot");

            holdingPuck = false;

            OnLaunch?.Invoke(x, z, power);
            powerGauge.SetActive(false);
        }
    }

    /// <summary>
    /// Launches puck if the player doesnt manually launch it after a period of time at min power
    /// </summary>
    /// <returns></returns>
    private IEnumerator TimeoutLaunchPuck()
    {
        yield return new WaitForSeconds(1f);

        if (holdingPuck)
        {
            if (playerLeft)
            {
                LaunchPuck(1, 0, _minimumPower);
            }
            else
            {
                LaunchPuck(-1, 0, _minimumPower);
            }
        }
    }

    /// <summary>
    /// Sets the duration of the dash
    /// </summary>
    /// <returns></returns>
    private IEnumerator DashTimeOut()
    {
        yield return new WaitForSeconds(.1f);
        _dashSpeed = 1;
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
