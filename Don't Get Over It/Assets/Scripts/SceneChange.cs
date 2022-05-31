using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChange : MonoBehaviour
{
    public void TitleScene()
    {
        SceneManager.LoadScene("Title");
        FindObjectOfType<AudioManager>().playAudio("Title Theme");
        FindObjectOfType<AudioManager>().stopAudio("Main Theme");
    }

    public void PauseScene()
    {
        SceneManager.LoadScene("Pause");
    }

    public void GameScene()
    {
        SceneManager.LoadScene("Jake");
        FindObjectOfType<AudioManager>().playAudio("Main Theme");
        FindObjectOfType<AudioManager>().stopAudio("Title Theme");
    }

    public void DeathScene()
    {
        SceneManager.LoadScene("Death");
    }

}
