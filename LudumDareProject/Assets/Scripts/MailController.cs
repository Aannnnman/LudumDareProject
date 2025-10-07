using UnityEngine;
using UnityEngine.UI;

public class MailController : MonoBehaviour
{
    [SerializeField] private Button[] _letterButtons; // ������
    [SerializeField] private GameObject _levelsMenu;  // ������ ���� �������
    [SerializeField] private LevelsMenuController _levelsMenuController; // ������ ���� �������

    private void OnEnable()
    {
        for (int i = 0; i < _letterButtons.Length; i++)
        {
            int index = i; // ����������� ������ ��� ������
            _letterButtons[i].onClick.AddListener(() => OnLetterClicked(index));
        }
    }

    private void OnLetterClicked(int letterIndex)
    {
        // ���������� ���� ������� (���� �� �������)
        if (!_levelsMenu.activeSelf)
            _levelsMenu.SetActive(true);

        // �������� ������ ���������� ������ (���������������� ������)
        _levelsMenuController.ShowLevel(letterIndex);
    }

    private void OnDisable()
    {
        // ������������ �� �������, ����� �������� ������ ������
        foreach (var button in _letterButtons)
            button.onClick.RemoveAllListeners();
    }
}
