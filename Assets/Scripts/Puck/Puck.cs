using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Puck : MonoBehaviour
{
    Vector3[] cardinals; //In order of NWSE
    internal Vector3 velocity;

    [SerializeField] internal GameObject leftPlayer;
    [SerializeField] internal GameObject rightPlayer;
    private GameObject _currPlayer;
    internal float currSpeed;

    void Awake()
    {
        Bounds bounds = transform.GetComponent<Collider>().bounds;
        cardinals = new Vector3[4];
        cardinals[0] = new Vector3(bounds.center.x, bounds.center.y, bounds.max.z);
        cardinals[1] = new Vector3(bounds.max.x, bounds.center.y, bounds.center.z);
        cardinals[2] = new Vector3(bounds.center.x, bounds.center.y, bounds.min.z);
        cardinals[3] = new Vector3(bounds.min.x, bounds.center.y, bounds.center.z);
    }

    void Start()
    {
        leftPlayer.GetComponent<PlayerControls>().OnLaunch += Launch;
        rightPlayer.GetComponent<PlayerControls>().OnLaunch += Launch;

        currSpeed = 10;
    }

    void Update()
    {
        transform.Translate(velocity * Time.deltaTime);
    }

    /// <summary>
    /// Launches the puck in a direction with a set speed
    /// </summary>
    /// <param name="x"></param>
    /// <param name="z"></param>
    /// <param name="speed"></param>
    internal void Launch(float x, float z, float speed)
    {
        // If the player launches soon enough
        if (speed > 16)
        {
            // Maintains currSpeed at less than 50
            if (currSpeed <= 50)
            {
                currSpeed *= 1.15f;
            }
        }
        else
        {
            currSpeed = speed;
        }

        velocity = new Vector3 (x * currSpeed, 0, z * currSpeed);
    }

    private void OnCollisionEnter(Collision other)
    {
        if (other.transform.CompareTag("Player"))
        {
            velocity = Vector3.zero;

            if (_currPlayer is GameObject)
            {
                _currPlayer.GetComponent<PlayerControls>().locked = false;
            }
            _currPlayer = other.gameObject;
            _currPlayer.GetComponent<PlayerControls>().locked = true;
        }
        else
        {
            AudioManager.Instance.Play("WallBounce");

            ContactPoint hitPos = other.GetContact(0);
            if (hitPos.normal.z == 0)
            {
                velocity = new Vector3(-velocity.x, 0, velocity.z);
            }
            else
            {
                velocity = new Vector3(velocity.x, 0, -velocity.z);
            }
        }
    }
}
