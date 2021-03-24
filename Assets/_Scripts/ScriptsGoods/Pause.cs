using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pause : MonoBehaviour
{
    // Pausa en el juego
    [SerializeField] private Canvas canvasPause;
    private bool isPause;
    private void Start()
    {
        canvasPause.enabled = false;
    }
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            PauseController();
        }
    }
    private void PauseController()
    {
        isPause = !isPause;
        canvasPause.enabled = isPause;
        if (canvasPause.enabled)
        {
            Time.timeScale = 0;
        }
        else
        {
            Time.timeScale = 1;
        }
    }
}
