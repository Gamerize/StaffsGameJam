using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EventManager : MonoBehaviour
{
    public GameObject PauseButtons;
    public GameObject Inventory;
    public bool paused = false;
    // Start is called before the first frame update
    void Start()
    {
        GameObject PauseButtons = GameObject.FindWithTag("Pause");
        Time.timeScale = 1;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape) && !paused)
        {
            if (Time.timeScale == 1)
            {
                Time.timeScale = 0;
                paused = true;
                PauseGame(PauseButtons);
            }
            else if (Time.timeScale == 0)
            {
                Time.timeScale = 1;
                unPauseGame(PauseButtons);
            }
        }
        else
        {
            paused = false;
        }

    }

    void PauseGame(GameObject PauseButtons)
    {
        PauseButtons.SetActive(true);
    }

    void unPauseGame(GameObject PauseButtons)
    {
        PauseButtons.SetActive(false);
    }

}
