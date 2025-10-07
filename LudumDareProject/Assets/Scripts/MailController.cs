using UnityEngine;
using UnityEngine.UI;

public class MailController : MonoBehaviour
{
    [SerializeField] private Button[] _letterButtons; // Письма
    [SerializeField] private GameObject _levelsMenu;  // Панель меню уровней
    [SerializeField] private LevelsMenuController _levelsMenuController; // Скрипт меню уровней

    private void OnEnable()
    {
        for (int i = 0; i < _letterButtons.Length; i++)
        {
            int index = i; // захватываем индекс для лямбды
            _letterButtons[i].onClick.AddListener(() => OnLetterClicked(index));
        }
    }

    private void OnLetterClicked(int letterIndex)
    {
        // Активируем меню уровней (если не активно)
        if (!_levelsMenu.activeSelf)
            _levelsMenu.SetActive(true);

        // Передаем индекс выбранного письма (соответствующего уровню)
        _levelsMenuController.ShowLevel(letterIndex);
    }

    private void OnDisable()
    {
        // Отписываемся от событий, чтобы избежать утечек памяти
        foreach (var button in _letterButtons)
            button.onClick.RemoveAllListeners();
    }
}
