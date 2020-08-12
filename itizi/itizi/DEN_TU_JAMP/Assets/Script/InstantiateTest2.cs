using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class InstantiateTest2 : MonoBehaviour {


    //生成するゲームオブジェクト
    public GameObject[] target;
    public GameObject World;
    //ランダム
    System.Random r = new System.Random(1000);
    //時間
    float countTime = 0;
    //はじめはn=3.00[s]
    float n = 5.0f, m = 0;

    int i = 1;

    void Update(){
        //スタートしてからの秒数を格納
        countTime -= Time.deltaTime;

        //位置調整
        float y;
        if (i >= 1)
        {
            y = -1.6f;
        }
        else
        {
            y = -0.1f;
        }

        //ランダム (敵の種類)
        int EnemyN = Random.Range(0, target.Length);
        if ((EnemyN==1)&&(y==-0.4f)) {
            y = 0f;
                }
        //n秒経ったら
        if (countTime  <= 0) {
            //Instantiate( 生成するオブジェクト,  場所, 回転 );                                   回転はそのままなら↓
            GameObject Teki =(GameObject) Instantiate (target[EnemyN], new Vector3 (11.0f, y, -1), Quaternion.identity);
            Debug.Log("inst");
            Teki.GetComponent<Transform>().parent = World.GetComponent<Transform>();
            //敵の出現スパンを徐々に小さくするよ
            if (m <= 3.5f)
            {
                m = m + 0.1f;
            }
            countTime = n - m;
	    }

        //ランダム (Y出現位置（-1.6 or -0.4))
        i = r.Next(0, 4);



        //接触時→STOP
        if (Den.owari == 1)
        {
            enabled = false;
        }

    }
}
