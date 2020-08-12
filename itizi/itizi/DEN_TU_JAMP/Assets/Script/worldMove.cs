using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class worldMove : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(-0.1f, 0, 0);
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
