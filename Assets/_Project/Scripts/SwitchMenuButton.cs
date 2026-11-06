using UnityEngine;
using UnityEngine.UI;

public class SwitchMenuButton : MonoBehaviour
{
    [SerializeField] private MenuType menuType;

    private Button button;

    private void Awake()
    {
        button = GetComponent<Button>();
    }

    private void OnEnable()
    {
        button.onClick.AddListener(SwitchMenu);
    }

    private void OnDisable()
    {
        button.onClick.RemoveListener(SwitchMenu);
    }

    private void SwitchMenu()
    {
        MenusManager.Instance.SwitchMenu(menuType);
    }
}
