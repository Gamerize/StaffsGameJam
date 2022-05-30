using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChange : MonoBehaviour
{
    public void TitleScene()
    {
        SceneManager.LoadScene("Title");
    }

    public void PauseScene()
    {
        SceneManager.LoadScene("Pause");
    }

    public void GameScene()
    {
        SceneManager.LoadScene("Jake");
    }

    public void DeathScene()
    {
        SceneManager.LoadScene("Death");
    }

}
