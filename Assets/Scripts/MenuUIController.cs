using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MenuUIController : MonoBehaviour
{
    public InputField nameInput;
    public void StartGame()
    {
        if (nameInput.text != "")
        {
            GameManager.instance.playerName = nameInput.text;
            SceneManager.LoadScene(1);
        }
    }
}
