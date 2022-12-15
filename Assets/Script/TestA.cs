using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestA : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Locator.Resolve<TestB>().OnDebug("aaaa");
    }
}
