using PixelCrushers;
using PixelCrushers.DialogueSystem;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneBehaviour : MonoBehaviour
{
    [SerializeField] GameObject _mainMenu;
    [SerializeField] GameObject _settingsMenu;
    [SerializeField] GameObject _keybindsMenu;

    bool showSettings;
    bool showKeybinds;

    public void showSettingsMenu()
    {
        _settingsMenu.gameObject.SetActive(true);
        showSettings = true;
        _mainMenu.gameObject.SetActive(false);
    }

    public void hideSettingsMenu()
    {
        _settingsMenu.gameObject.SetActive(false);
        showSettings = false;
        _mainMenu.gameObject.SetActive(true);
    }

    public void showKeybindsMenu()
    {
        _keybindsMenu.gameObject.SetActive(true);
        showKeybinds = true;
        _settingsMenu.gameObject.SetActive(false);
    }

    public void hideKeybindsMenu()
    {
        _keybindsMenu.gameObject.SetActive(false);
        showKeybinds = false;
        _settingsMenu.gameObject.SetActive(true);
    }

    public void QuitGame()
    {
        Application.Quit();
        Debug.Log("Quit clicked, Game was quit in thought");
    }
}
