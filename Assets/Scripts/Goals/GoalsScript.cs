using System;
using UnityEngine;
using Cinemachine;

public class GoalsScript : MonoBehaviour
{
    public bool leftGoal;
    CinemachineImpulseSource source;

    public event Action<int> OnLeftGainPoint;
    public event Action<int> OnRightGainPoint;

    void Start()
    {
        source = GetComponent<CinemachineImpulseSource>();
    }

    private void OnCollisionEnter(Collision other)
    {
        if (other.transform.CompareTag("Puck"))
        {
            AudioManager.Instance.Play("Score");
            source.GenerateImpulse(Camera.main.transform.forward);

            if (leftGoal)
            {
                OnRightGainPoint?.Invoke(1);
            }
            else
            {
                OnLeftGainPoint?.Invoke(1);
            }
        }
    }
}
