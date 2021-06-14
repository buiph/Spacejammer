using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScrollingEffect : MonoBehaviour
{
    public Transform starQuadRevolvePos;
    public GameObject[] starQuads;

    void Update()
    {
        starQuads[0].transform.Translate(-transform.up * Time.deltaTime);
        starQuads[1].transform.Translate(-transform.up * Time.deltaTime);
        starQuads[2].transform.Translate(-transform.up * Time.deltaTime);
    }

    void OnTriggerEnter(Collider other)
    {
        other.transform.position = starQuadRevolvePos.position;
    }
}
