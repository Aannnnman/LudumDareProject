using UnityEngine;
using UnityEngine.SceneManagement;

public class ReturnInMenu : MonoBehaviour
{
    private void OnEnable()
    {
        CollectableVirus.OnVirusTaked += ReturnMenuScene;
    }

    private void OnDisable()
    {
        CollectableVirus.OnVirusTaked -= ReturnMenuScene;
    }

    private void ReturnMenuScene()
    {
        SceneManager.LoadScene("Menu");
    }
}
