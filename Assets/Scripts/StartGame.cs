using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class StartGame : MonoBehaviour
{
    public void playBtn()
    {
        SceneManager.LoadScene("Game");
    }

    public void exitBTN()
    {
        Application.Quit();
    }
}
