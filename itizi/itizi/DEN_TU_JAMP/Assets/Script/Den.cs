using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Den : MonoBehaviour {

    //変数定義
    public float flap = 1000f;
    public float scroll = 5f;
    float direction = 0f;
    Rigidbody2D rb2d;
    bool jump = false;
    public static int owari = 0;
    GameObject gameobject;
    public GameObject button;

    // Use this for initialization
    void Start () {
        //コンポーネント読み込み
        rb2d = GetComponent<Rigidbody2D>();
    }


    private string enemyTag = "DamageObject";

    // Update is called once per frame
    void Update () {

        //キーボード操作
        /*if (Input.GetKey(KeyCode.RightArrow))
        {
            direction = 1f;
        }else if (Input.GetKey(KeyCode.LeftArrow))
        {
            direction = -1f;
        }else
        {
            direction = 0f;
        }*/


        //キャラのy軸のdirection方向にscrollの力をかける
        rb2d.velocity = new Vector2(scroll * direction, rb2d.velocity.y);

        //ジャンプ判定
        if (Input.GetKeyUp(KeyCode.UpArrow) && !jump)
        {
            rb2d.AddForce(Vector2.up * flap);
            jump = true;
        }
        if (owari == 1)
        {
            if (Input.GetKeyUp(KeyCode.UpArrow))
            {
                owari = 0;
                Application.LoadLevel(Application.loadedLevel);
            }
        }

    }
    public GameObject Timer;
    #region//接触判定
    private TimerScript TM;
    private void OnCollisionEnter2D(Collision2D collision)
    {

        if (collision.collider.tag == enemyTag)
        {
            Debug.Log("敵と接触した！");
            owari = 1;
        }
        else
        {
            jump = false;
        }

    }
    #endregion

    /*    void OnCollisionEnter2D(Collision2D other)
        {
            if (other.gameObject.CompareTag("Ground"))
            {
                jump = false;
            }
        }
        */
}