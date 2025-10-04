using UnityEngine;
using UnityEngine.UI;

public class LevelButton : MonoBehaviour
{
    [SerializeField] private Text _levelNumberText;
    [SerializeField] private GameObject _starsRoot;
    [SerializeField] private GameObject[] _stars;
    [SerializeField] private GameObject _lockIcon;
    [SerializeField] private Button _button;

    public void SetLevelData(int levelNumber, int starScore)
    {
        _levelNumberText.text = levelNumber.ToString();

        for (int i = 0; i < _stars.Length; i++)
        {
            if (i > starScore - 1)
                _stars[i].SetActive(false);
        }

        _button.interactable = true;
        _lockIcon.SetActive(false);
        _levelNumberText.gameObject.SetActive(true);
        _starsRoot.SetActive(true);
    }
}
