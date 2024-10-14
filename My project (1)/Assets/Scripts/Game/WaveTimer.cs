using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class WaveTimer : MonoBehaviour
{
    [SerializeField] private Slider slider_wave;
    [SerializeField] private float _maxTime_wave;
    [SerializeField] private float _curTime_wave;
    [SerializeField] private int _enemies;
    [SerializeField] private int _plusEnemies;
    [SerializeField] private TextMeshProUGUI _wavesText;
    [SerializeField] public Hire _warriorObject;
    [SerializeField] private Hire _farmerObject;
    [SerializeField] private GameObject _endGame;
    [SerializeField] private TextMeshProUGUI _warriorCount;
    [SerializeField] private TextMeshProUGUI _farmerCount;
    [SerializeField] PauseScript _pauseScript;
    // Start is called before the first frame update
    void Start()
    {
        _maxTime_wave = PlayerPrefs.GetInt("_waveTime");
        _warriorObject._warrior = PlayerPrefs.GetInt("_startWarrior");
        _warriorObject._workerText.text = _warriorObject._warrior.ToString(); 
        _farmerObject._farmer = PlayerPrefs.GetInt("_startFarmer");
        _farmerObject._workerText.text = _farmerObject._farmer.ToString();
        _curTime_wave = _maxTime_wave;
    }

    // Update is called once per frame
    void Update()
    {
        if (_pauseScript._isPaused == true)
        {
            return;
        }
        if (_curTime_wave >= 0)
        {
            _curTime_wave -= Time.deltaTime;
            slider_wave.value = _curTime_wave / _maxTime_wave;
        }
        else
        {
            Fight();
            _enemies += Random.Range(1 + _plusEnemies, 3 + _plusEnemies);
            _plusEnemies += 1;
            _curTime_wave = _maxTime_wave;
            _wavesText.text = "Волна. Врагов: " + _enemies.ToString();
        }
    }
    private void Fight()
    {
        int _curEnemies = _enemies;
        if (_curEnemies <= _warriorObject._warrior)
        {
            Debug.Log("a");
            _warriorObject._warrior -= _curEnemies;
            _warriorCount.text = _warriorObject._warrior.ToString();
            return;
        }
        else if (_curEnemies <= _warriorObject._warrior + _farmerObject._farmer / 3)
        {
            Debug.Log("b");
            _curEnemies -= _warriorObject._warrior;
            _farmerObject._farmer -= _curEnemies*3;
            _farmerCount.text = _farmerObject._farmer.ToString();
            _warriorCount.text = 0.ToString();
            return;
        }
        else
        {
            Debug.Log("c");
            _endGame.SetActive(true);
        }
    }


}
