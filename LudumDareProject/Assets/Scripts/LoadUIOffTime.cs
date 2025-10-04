using UnityEngine;

public class LoadUIOffTime : MonoBehaviour
{
    [SerializeField] private float _maxTime;

    private void OnEnable()
    {
        Invoke(nameof(StartTimer), _maxTime);
    }

    private void StartTimer()
    {
        gameObject.SetActive(false);
    }
}
