using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class InstantiateTest : MonoBehaviour {
    //生成するゲームオブジェクト
    public GameObject target;
    float countTime = 3;
    void Update(){
        countTime -= Time.deltaTime; //スタートしてからの秒数を格納
        //スペースを押したら
        if (countTime  <= 0) {
            //Instantiate( 生成するオブジェクト,  場所, 回転 );  回転はそのままなら↓
        
	    Instantiate (target, new Vector3 (12.0f, -1.0f, 0.0f), Quaternion.identity);
            countTime = 3;
        }
        if (Den.owari == 1)
         {
             enabled = false;
         }
    }
}