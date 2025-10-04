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

            if (i < _levelData.Length + 1)
            {
                int starScore = 0;

                if (i < _levelData.Length)
                    starScore = _levelData[i];
                //int starScore = Random.Range(0, _maxStars + 1);
                newButton.SetLevelData(i + 1, starScore);
            }
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
