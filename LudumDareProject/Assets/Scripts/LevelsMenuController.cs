using UnityEngine;

public class LevelsMenuController : MonoBehaviour
{
    [SerializeField] private LevelButton[] _levels; // ”ровни (кнопки/панели/префабы)

    public void ShowLevel(int index)
    {
        // ¬ключаем только нужный, если индекс валидный
        if (index >= 0 && index < _levels.Length)
            _levels[index].ActivateLevel();
    }
}
