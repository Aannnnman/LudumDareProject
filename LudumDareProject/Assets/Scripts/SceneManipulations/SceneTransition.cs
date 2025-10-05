using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneTransition : MonoBehaviour
{
    [SerializeField] private int _sceneNumber;

    public void ChangeScene()
    {
        SceneManager.LoadScene(_sceneNumber);
    }
}
