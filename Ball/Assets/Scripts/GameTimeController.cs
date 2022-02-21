using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameTimeController 
{
    public void PauseGame()
    {
        Time.timeScale = 0f;
    }

    public void UnpauseGame()
    {
        Time.timeScale = 1f;
    }
}
