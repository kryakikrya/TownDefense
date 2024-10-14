using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Options : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI _waveTime;
    [SerializeField] TextMeshProUGUI _startWheat;
    [SerializeField] TextMeshProUGUI _startFarmers;
    [SerializeField] TextMeshProUGUI _startWarrior;
    private void Start()
    {
        _waveTime.text = PlayerPrefs.GetInt("_waveTime").ToString();
        _startWheat.text = PlayerPrefs.GetInt("_startWheat").ToString();
        _startFarmers.text = PlayerPrefs.GetInt("_startFarmer").ToString();
        _startWarrior.text = PlayerPrefs.GetInt("_startWarrior").ToString();
    }
    public void WaveTimePlus()
    {
        if (PlayerPrefs.GetInt("_waveTime") < 120) { PlayerPrefs.SetInt("_waveTime", PlayerPrefs.GetInt("_waveTime") + 5); }
        _waveTime.text = PlayerPrefs.GetInt("_waveTime").ToString();
    }
    public void WaveTimeMinus()
    {
        if (PlayerPrefs.GetInt("_waveTime") > 5) { PlayerPrefs.SetInt("_waveTime", PlayerPrefs.GetInt("_waveTime") - 5); }
        _waveTime.text = PlayerPrefs.GetInt("_waveTime").ToString();
    }
    public void StartWheatPlus()
    {
        PlayerPrefs.SetInt("_startWheat", PlayerPrefs.GetInt("_startWheat") + 5);
        _startWheat.text = PlayerPrefs.GetInt("_startWheat").ToString();
    }
    public void StartWheatMinus()
    {
         if (PlayerPrefs.GetInt("_startWheat") > 0)
        {
            PlayerPrefs.SetInt("_startWheat", PlayerPrefs.GetInt("_startWheat") - 5);
            _startWheat.text = PlayerPrefs.GetInt("_startWheat").ToString();
        }
    }
    public void StartFarmersPlus()
    {
        PlayerPrefs.SetInt("_startFarmer", PlayerPrefs.GetInt("_startFarmer") + 1);
        _startFarmers.text = PlayerPrefs.GetInt("_startFarmer").ToString();
    }
    public void StartFarmersMinus()
    {
        if (PlayerPrefs.GetInt("_startFarmer") > 0)
        {
            PlayerPrefs.SetInt("_startFarmer", PlayerPrefs.GetInt("_startFarmer") - 1);
            _startFarmers.text = PlayerPrefs.GetInt("_startFarmer").ToString();
        }
    }
    public void StartWarriorsPlus()
    {
        PlayerPrefs.SetInt("_startWarrior", PlayerPrefs.GetInt("_startWarrior") + 1);
        _startWarrior.text = PlayerPrefs.GetInt("_startWarrior").ToString();
    }
    public void StartWarriorsMinus()
    {
        if (PlayerPrefs.GetInt("_startWarrior") > 0)
        {
            PlayerPrefs.SetInt("_startWarrior", PlayerPrefs.GetInt("_startWarrior") - 1);
            _startWarrior.text = PlayerPrefs.GetInt("_startWarrior").ToString();
        }
    }
}
