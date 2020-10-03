using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SceneMgr : MonoBehaviour
{
    public void BackToTheScene()
    {
        Scene scene = SceneManager.GetActiveScene();
        int currScene = scene.buildIndex;
        SceneManager.LoadScene(currScene-1);
    }
    public void GameStart()
    {
        SceneManager.LoadScene("02.MainMenu");
    }
    public void MainMenu()
    {
        SceneManager.LoadScene("03.Game Mode");
    }
    public void GameMode()
    {
        SceneManager.LoadScene("04.Alone Mode");
    }
    public void AloneMode_1()
    {
        SceneManager.LoadScene("05-1.Alone Mode");
    }
    public void AloneMode_2()
    {
        SceneManager.LoadScene("05-2.Alone Mode");
    }
    public void AloneMode_3()
    {
        SceneManager.LoadScene("05-3.Alone Mode");
    }
    public void GamePlay()
    {
        SceneManager.LoadScene("GamePlayScene");
    }
}
