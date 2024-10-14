using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    [SerializeField] private Slider slider;
    [SerializeField] private float _maxTime;
    [SerializeField] private float _curTime;
    public int _wheat;
    [SerializeField] public TextMeshProUGUI _wheatText;
    [SerializeField] Hire _hireObject;
    [SerializeField] PauseScript _pauseScript;
    // Start is called before the first frame update
    void Start()
    {
        _hireObject._farmer = 1;
    }

    // Update is called once per frame
    void Update()
    {
        if( _pauseScript._isPaused == true)
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
            _wheat += _hireObject._farmer;
            _curTime = _maxTime;
            _wheatText.text = _wheat.ToString();
        }
    }
}
