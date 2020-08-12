using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rot : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
    }
    // Update is called once per frame
    void Update()
    {
        this.transform.Rotate(0.0f, 0.0f, 10.0f);


        if (Den.owari == 1)
        {
            enabled = false;
        }
        else
        {
            enabled = true;
        }
    }
}
