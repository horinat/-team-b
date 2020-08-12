using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class GameOverScript : MonoBehaviour
{

    void Start()
    {
        this.gameObject.GetComponent<Text>().enabled = false;
    }

    public void Update()
    {
        if(Den.owari == 1)
        this.gameObject.GetComponent<Text>().enabled = true;
    }
}