using UnityEngine;
using UnityEngine.UI;

public class ObjectsOffOrOnButton : MonoBehaviour
{
    [SerializeField] private Button _button;
    [SerializeField] private GameObject[] _toOff;
    [SerializeField] private GameObject[] _toOn;

    private void OnEnable()
    {
        _button.onClick.AddListener(OffObjects);
        _button.onClick.AddListener(OnObjects);
    }

    private void OnDisable()
    {
        _button.onClick.RemoveListener(OffObjects);
        _button.onClick.RemoveListener(OnObjects);
    }

    private void OffObjects()
    {
        foreach (var obj in _toOff)
        {
            obj.SetActive(false);
        }
    }

    private void OnObjects()
    {
        foreach (var obj in _toOn)
        {
            obj.SetActive(true);
        }
    }
}
