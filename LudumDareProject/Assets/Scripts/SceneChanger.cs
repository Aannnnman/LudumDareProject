using UnityEngine;
using UnityEngine.SceneManagement; // ОБЯЗАТЕЛЬНО нужно добавить эту строку!

public class SceneChanger : MonoBehaviour
{
    // Этот метод мы сделаем публичным, чтобы его можно было вызвать с кнопки.
    // Он принимает в качестве параметра имя сцены, которую нужно загрузить.
    public void LoadScene(string sceneName)
    {
        // Проверяем, что имя сцены не пустое
        if (!string.IsNullOrEmpty(sceneName))
        {
            // Главная команда для загрузки сцены по ее имени
            SceneManager.LoadScene(sceneName);
        }
        else
        {
            Debug.LogError("Имя сцены не указано!");
        }
    }
}
