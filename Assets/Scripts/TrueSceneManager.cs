using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TrueSceneManager : MonoBehaviour
{
    public void StandardGame()
    {
        Game.isPressed = false;
        SceneManager.LoadScene(1);
    }

    public void Chess960()
    {
        Game.isPressed = true;
        SceneManager.LoadScene(1);
    }


}
