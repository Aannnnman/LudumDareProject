using UnityEngine;

public class LevelMenuViewer : MonoBehaviour
{
    [SerializeField] private LevelButton[] _levels;

    private VirusCounter _virusCounter;

    private void OnEnable()
    {
        _virusCounter = FindAnyObjectByType<VirusCounter>();
        HowManyLevelsUnlock();
    }

    private void HowManyLevelsUnlock()
    {
        switch (_virusCounter.VirusCount)
        {
            case 0:
                _levels[0].ActivateLevel();
                break;
            case 1:
                _levels[1].ActivateLevel();
                break;
            case 2:
                _levels[2].ActivateLevel();
                break;
            case 3:
                _levels[3].ActivateLevel();
                break;
            case 4:
                _levels[4].ActivateLevel();
                break;
        }
    }
}
