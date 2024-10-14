using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnpauseScript : MonoBehaviour
{
    [SerializeField] GameObject _pausePanel;
    [SerializeField] PauseScript _pauseScript;
    public void Unpause()
    {
        _pauseScript._isPaused = false;
        _pausePanel.SetActive(false);
    }
}
