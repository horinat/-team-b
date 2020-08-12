using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class wave : MonoBehaviour
{
    //スタートしてからの秒数を格納
    float countTime = 0;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        //スタートしてからの秒数を格納
        countTime += Time.deltaTime;
        while (countTime <= 360)
        {
            float sin = Mathf.Sin(countTime * (Mathf.PI / 180f));
            this.transform.Translate(0, sin, 0);
        }
        countTime = 0;
    }
}
