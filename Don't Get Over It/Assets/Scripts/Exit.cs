using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Exit : MonoBehaviour
{
    public void exitgame()
    {
        Debug.Log("Exited Game");
        Application.Quit();

    }
}
