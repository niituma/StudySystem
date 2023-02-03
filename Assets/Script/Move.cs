using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    [SerializeField]
    GameObject _red;
    [SerializeField]
    GameObject _blue;
    public float deg_B = 2f * Mathf.PI / 360f;
    public float deg_R = 0f;
    public float waveRad = 3f;
    public float wave = 2f;

    // Update is called once per frame
    void FixedUpdate()
    {
        if (_red)
        {
            //deg_R += 0.01745329251f;
            deg_R += 2f * Mathf.PI / 360f / 2f;
            waveRad += 2f * Mathf.PI / 360f;

            _red.transform.position = new Vector3(
                (5f + Mathf.Sin(waveRad * wave / 2f)) * Mathf.Cos(deg_R),
                0.5f,
                (5f + Mathf.Sin(waveRad * wave / 2f)) * Mathf.Sin(deg_R));
        }

        if (_blue)
        {
            _blue.transform.position = new Vector3(
                _blue.transform.position.x * Mathf.Cos(deg_B) - _blue.transform.position.z * Mathf.Sin(deg_B),
                _blue.transform.position.y,
                _blue.transform.position.x * Mathf.Sin(deg_B) + _blue.transform.position.z * Mathf.Cos(deg_B)
                );
        }
    }
}
