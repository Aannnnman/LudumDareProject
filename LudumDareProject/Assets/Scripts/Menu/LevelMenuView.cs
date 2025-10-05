using UnityEngine;

public class LevelMenuView : MonoBehaviour
{
    [SerializeField] private int _levelCount;
    [SerializeField] private LevelButton _levelButtonPrefab;
    [SerializeField] private RectTransform _root;
    [SerializeField] private int[] _levelData;

    private void Awake()
    {
        ClearRoot();
        InitLevelButtons();
    }

    private void InitLevelButtons()
    {
        int spawnCount = _levelCount < _levelData.Length ? _levelData.Length : _levelCount;

        for (int i = 0; i < spawnCount; i++)
        {
            LevelButton newButton = Instantiate(_levelButtonPrefab, _root);

            bool isLocked = true;

            // Ћогика определени€ заблокирован ли уровень
            if (i < _levelData.Length)
            {
                // ƒопустим, если _levelData[i] == 1, уровень открыт
                isLocked = (_levelData[i] == 0);
            }
            else
            {
                // ”ровни вне данных считаем закрытыми
                isLocked = true;
            }

            //newButton.SetLevelData(i + 1, isLocked);
        }
    }

    private void ClearRoot()
    {
        for (int i = 0; i < _root.childCount; i++)
        {
            Destroy(_root.GetChild(i).gameObject);
        }
    }
}
