using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    [SerializeField] private Button buttonPlay = null;
    [SerializeField] private Button buttonSettings = null;

    [SerializeField] private SettingsManager settingsManager = null;
    [SerializeField] private PlayManager playManager = null;

    private void Awake()
    {
        buttonPlay.onClick.AddListener(playManager.Enable);
        buttonSettings.onClick.AddListener(settingsManager.Enable);
    }
}
