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
    [SerializeField] GameObject _winPanel;
    [SerializeField] GameObject _gamePanel;
    // Start is called before the first frame update
    void Start()
    {
        _wheat = PlayerPrefs.GetInt("_startWheat");
        _wheatText.text = _wheat.ToString();
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
            _wheat += PlayerPrefs.GetInt("_curFarmer");
            if (_wheat > 1000 && PlayerPrefs.GetInt("_curFarmer") > 30)
            {
                _gamePanel.SetActive(false);
                _winPanel.SetActive(true);
            }
            _curTime = _maxTime;
            _wheatText.text = _wheat.ToString();
        }
    }
}
