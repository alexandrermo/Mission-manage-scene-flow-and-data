using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MainUIController : MonoBehaviour
{
    public Text scoreText;
    // Start is called before the first frame update
    void Start()
    {
        scoreText.text = scoreText.text.Replace("Name", GameManager.GetPlayerName());
    }

    // Update is called once per frame
    void Update()
    {

    }
}
