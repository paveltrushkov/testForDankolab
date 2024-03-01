using UnityEngine;
using UnityEngine.UI;

public class SettingsManager : MonoBehaviour
{
    [SerializeField] private Button buttonClose = null;

    private void Awake()
    {
        buttonClose.onClick.AddListener(Disable);
    }

    public void Enable()
    {
        this.gameObject.SetActive(true);
    }

    public void Disable()
    {
        this.gameObject.SetActive(false);
    }
}
