using UnityEngine;
using UnityEngine.UI;

public class PlayObject : MonoBehaviour
{
    private void Awake()
    {
        GetComponent<Button>().onClick.AddListener(OnClick);
    }

    private void OnClick()
    {
        Destroy(gameObject);
    }
}
