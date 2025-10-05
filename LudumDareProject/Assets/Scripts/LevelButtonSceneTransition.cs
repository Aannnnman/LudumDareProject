using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LevelButtonSceneTransition : MonoBehaviour
{
    [SerializeField] private Button _button;
    [SerializeField] private string _sceneName;

    private void OnEnable()
    {
        _button.onClick.AddListener(LevelScene);
    }

    private void OnDisable()
    {
        _button.onClick.RemoveListener(LevelScene);
    }

    private void LevelScene()
    {
        SceneManager.LoadScene(_sceneName);
    }
}
