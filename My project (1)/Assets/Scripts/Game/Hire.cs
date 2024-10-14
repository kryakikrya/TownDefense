using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
public class Hire : MonoBehaviour
{
    [SerializeField] private Slider slider;
    [SerializeField] private float _maxTime;
    [SerializeField] private float _curTime;
    [SerializeField] private int _workerType;
    public int _warrior;
    [SerializeField] public TextMeshProUGUI _workerText;
    bool _sliderCheck = false;
    [SerializeField] private Timer _timerObject;
    [SerializeField] private Button _button;
    [SerializeField] private int _price;
    [SerializeField] PauseScript _pauseScript;
    // Start is called before the first frame update
    void Start()
    {
        _curTime = _maxTime;
    }

    // Update is called once per frame
    void Update()
    {
        if (_pauseScript._isPaused == true)
        {
            return;
        }
        if (_timerObject._wheat < _price)
        {
            _button.enabled = false;
        }
        else
        {
            _button.enabled = true;
        }
        if (_sliderCheck)
        {
            if (_curTime >= 0)
            {
                _button.enabled = false;
                _curTime -= Time.deltaTime;
                slider.value = _curTime / _maxTime;
            }
            else
            {
                _button.enabled = true;
                // Type 0 - warrior, Type 1 - Farmer
                if (_workerType == 0)
                {
                    _warrior++;
                    _workerText.text = _warrior.ToString();
                }
                if (_workerType == 1)
                {
                    PlayerPrefs.SetInt("_startFarmer", PlayerPrefs.GetInt("_startFarmer") + 1);
                    _workerText.text = PlayerPrefs.GetInt("_startFarmer").ToString();
                }
                _curTime = _maxTime;
                _sliderCheck = false;
            }
        }
    }
    public void ButtonClick()
    {
        _sliderCheck = true;
        _timerObject._wheat -= _price;
        _timerObject._wheatText.text = _timerObject._wheat.ToString();
    }
}