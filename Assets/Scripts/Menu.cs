using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine;

public class Menu : MonoBehaviour
{
    public void Play(int num)
    {
        SceneManager.LoadScene(num);
    }
    public void ExitGame()
    {
        Application.Quit();
    }
}
