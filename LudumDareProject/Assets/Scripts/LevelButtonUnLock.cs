using UnityEngine;

public class LevelButtonUnLock : MonoBehaviour
{
    [SerializeField] private GameObject _lockImage;

    private VirusCounter _virusCounter;

    private void OnEnable()
    {
        _virusCounter = FindFirstObjectByType<VirusCounter>();
        CheckUnlocking();
    }

    private void CheckUnlocking()
    {
        int[] unlockValues = { 0, 1, 2, 3, 4 };

        if (System.Array.Exists(unlockValues, value => value == _virusCounter.VirusCount))
        {
            _lockImage.SetActive(false);
        }
    }
}
