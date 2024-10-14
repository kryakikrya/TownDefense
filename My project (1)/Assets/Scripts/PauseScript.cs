using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseScript : MonoBehaviour
{
    [SerializeField] GameObject _pausePanel;
    public bool _isPaused;

    public void Pause()
    {
        _isPaused = true;
        _pausePanel.SetActive(true);
    }
}
