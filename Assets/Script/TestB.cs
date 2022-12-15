using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestB : MonoBehaviour
{
    private void Awake()
    {
        Locator.Register<TestB>(this);
    }

    public void OnDebug(string log)
    {
        Debug.Log(log);
    }
}
