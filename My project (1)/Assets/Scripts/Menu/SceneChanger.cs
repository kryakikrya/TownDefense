using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;
public class SceneChanger : MonoBehaviour
{
    AsyncOperation asyncOperation;
    [SerializeField] UnityEngine.UI.Image _loadBar;
    [SerializeField] int _sceneID;
    [SerializeField] GameObject _loadingPanel;
    [SerializeField] GameObject _menuPanel;

    private void Start()
    {

    }
    IEnumerator LoadScene()
    {
        yield return new WaitForSeconds(1f);
        asyncOperation = SceneManager.LoadSceneAsync(_sceneID);
        while (!asyncOperation.isDone)
        {
            float progress = asyncOperation.progress / 0.9f;
            _loadBar.fillAmount = progress;
            yield return 0;
        }
    }
    IEnumerator LoadSceneNew()
    {
        yield return new WaitForSeconds(1f);
        asyncOperation = SceneManager.LoadSceneAsync(1);
        while (!asyncOperation.isDone)
        {
            float progress = asyncOperation.progress / 0.9f;
            _loadBar.fillAmount = progress;
            yield return 0;
        }
    }
    public void StartButtonClick()
    {
        _menuPanel.SetActive(false);
        _loadingPanel.SetActive(true);
        StartCoroutine(LoadScene());
    }
    public void NewGame()
    {
        _menuPanel.SetActive(false);
        _loadingPanel.SetActive(true);
        StartCoroutine(LoadSceneNew());

    }
}
