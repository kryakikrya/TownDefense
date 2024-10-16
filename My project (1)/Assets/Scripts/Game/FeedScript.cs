using System.Collections;
using System.Collections.Generic;
using System.Timers;
using UnityEngine;
using UnityEngine.UI;
public class FeedScript : MonoBehaviour
{
    [SerializeField] private Slider slider;
    [SerializeField] private float _maxTime;
    [SerializeField] private float _curTime;
    [SerializeField] private Timer _wheatObject;
    [SerializeField] Hire _warriorObject;
    [SerializeField] PauseScript _pauseScript;

    void Update()
    {
        if (_pauseScript._isPaused == true)
        {
            return;
        }
        if (_curTime >= 0)
        {
            _curTime -= Time.deltaTime;
            slider.value = _curTime / _maxTime;
        }
        else
        {
            if (_warriorObject._warrior >= _wheatObject._wheat)
            {
                _warriorObject._warrior -= _warriorObject._warrior - _wheatObject._wheat;
                _wheatObject._wheat = 0;
            }
            else
            {
                _wheatObject._wheat -= _warriorObject._warrior;
                _curTime = _maxTime;
            }
        }
    }
}
