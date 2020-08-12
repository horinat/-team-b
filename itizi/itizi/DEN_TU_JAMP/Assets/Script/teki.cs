using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class teki : MonoBehaviour
{
    private string enemyTag = "Respawn";
    public bool isSpana;
    void Update()
    {        
        // transformを取得
        Transform myTransform = this.transform;
 
        // 座標を取得
        Vector3 pos = myTransform.position;
       /* if (isSpana)
        {
            transform.Translate(-0.2f, 0, 0);
        }
        else
        {
            transform.Translate(-0.1f, 0, 0);
        }*/
        if (transform.position.x < -13.8f)
        {
            transform.position = new Vector3(13.8f, 0, -1);
        }    
        //接触時→STOP
        if (Den.owari == 1)
        {
            enabled = false;
        }
        else
        {
            enabled = true;
        }
        

        
    }
    #region//接触判定
    private void OnCollisionEnter2D(Collision2D collision)
    {

        if (collision.collider.tag == enemyTag)
        {
	    Destroy (this.gameObject);
        }

    }
    #endregion

}

  
