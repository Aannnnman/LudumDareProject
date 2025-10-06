using UnityEngine;

public class LevelsMenuController : MonoBehaviour
{
    [SerializeField] private LevelButton[] _levels; // ������ (������/������/�������)

    public void ShowLevel(int index)
    {
        // �������� ������ ������, ���� ������ ��������
        if (index >= 0 && index < _levels.Length)
            _levels[index].ActivateLevel();
    }
}
