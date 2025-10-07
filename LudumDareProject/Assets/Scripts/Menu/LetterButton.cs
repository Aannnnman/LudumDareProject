using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using System;

public class LetterButton : MonoBehaviour
{
    // Ключ для сохранения в PlayerPrefs. Должен быть одинаковым для всех кнопок.
    private const string PREFS_KEY = "LastSelectedMissionID";

    // Статическая переменная по-прежнему нужна для мгновенной реакции в пределах одной сессии меню
    private static LetterButton _selectedButton; 

    public static event Action OnLetterClick;

    [Header("UI Elements")]
    [SerializeField] private Button _letterButton;
    [SerializeField] private Text _letterButtonText;
    [SerializeField] private Text _letterText;
    [SerializeField] private Text[] _letterTextParts;

    [Header("Button Content & Behavior")]
    [SerializeField] private Color _changeColor;
    [SerializeField] private string _startMissionText = "Start (Double click)";
    [SerializeField] private string _whatInLetterText;
    [SerializeField] private string _from;
    [SerializeField] private string _data;
    [SerializeField] private string _toWhom;
    [SerializeField] private string _top;

    [Header("Level Loading")]
    // Эта строка теперь будет нашим УНИКАЛЬНЫМ ИДЕНТИФИКАТОРОМ
    [SerializeField] private string _sceneToLoad; 

    private Color _originColor;
    private string _originalButtonText;

    private void Awake()
    {
        if (_letterButtonText != null)
        {
            _originColor = _letterButtonText.color;
            _originalButtonText = _letterButtonText.text;
        }
    }

    private void OnEnable()
    {
        _letterButton.onClick.AddListener(OnButtonPressed);

        // *** НОВЫЙ БЛОК: Проверка при активации объекта ***
        // Получаем сохраненный ID миссии из памяти
        string savedMissionID = PlayerPrefs.GetString(PREFS_KEY, "");

        // Если сохраненный ID совпадает с ID ЭТОЙ кнопки
        if (!string.IsNullOrEmpty(savedMissionID) && savedMissionID == _sceneToLoad)
        {
            // Немедленно переключаем эту кнопку в "выбранное" состояние
            SetAsSelected();
        }
    }

    private void OnDisable()
    {
        _letterButton.onClick.RemoveListener(OnButtonPressed);
    }

    private void OnButtonPressed()
    {
        if (_selectedButton == this)
        {
            // Загружаем уровень
            if (!string.IsNullOrEmpty(_sceneToLoad))
            {
                // Важно! Можно здесь же и очищать выбор, если хотите, чтобы после миссии он сбрасывался.
                // PlayerPrefs.DeleteKey(PREFS_KEY); 
                SceneManager.LoadScene(_sceneToLoad);
            }
            else
            {
                Debug.LogWarning("Имя сцены для загрузки не указано!", this.gameObject);
            }
        }
        else
        {
            if (_selectedButton != null)
            {
                _selectedButton.ResetState();
            }

            SetAsSelected();

            // *** НОВАЯ СТРОКА: Сохраняем выбор ***
            // Записываем ID этой миссии в память, чтобы он сохранился после перезагрузки
            PlayerPrefs.SetString(PREFS_KEY, _sceneToLoad);
        }
    }

    private void SetAsSelected()
    {
        _letterButtonText.text = _startMissionText;
        _letterButtonText.color = _changeColor;
        ShowLetterText();
        _selectedButton = this;
    }
    
    private void ShowLetterText()
    {
        OnLetterClick?.Invoke();

        foreach (var letterTextPart in _letterTextParts)
        {
            letterTextPart.gameObject.SetActive(true);
        }

        _letterText.text = _whatInLetterText;
        _letterTextParts[0].text = _from;
        _letterTextParts[1].text = _data;
        _letterTextParts[2].text = _toWhom;
        _letterTextParts[3].text = _top;
    }
    
    public void ResetState()
    {
        _letterButtonText.text = _originalButtonText;
        _letterButtonText.color = _originColor;
    }
}
