using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Hello From Test");
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        Debug.Log("Hello From FixedUpdate");
    }
    void Update()
    {
        Debug.Log("Hello From Update");
    }
    private void OnEnable()
    {
        Debug.Log("Hello From OnEnable");
    }
}
