using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class GameOverButtonScript : MonoBehaviour
{

    public Text gameOver;
    bool gameOverFlag;

    void Update()
    {
        if (gameOverFlag && Input.GetMouseButtonDown(0))
        {
            Application.LoadLevel("title");
        }
    }

    public void ButtonPush()
    {
        gameOver.SendMessage("Lose");
        gameOverFlag = true;
    }
}