using UnityEngine;
using UnityEngine.SceneManagement;

public class ReLoadActiveScene : MonoBehaviour
{
    private void OnEnable()
    {
        KillZone.OnDeath += ReLoadScene;
    }

    private void OnDisable()
    {
        KillZone.OnDeath -= ReLoadScene;
    }

    private void ReLoadScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
