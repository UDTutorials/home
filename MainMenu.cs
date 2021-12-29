using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public Button PlayButton;
    public Button OptionsButton;
    public Button CreditsButton;
    public Button ExitButton;
    public Canvas OptionsMenu;
    public Canvas CreditsMenu;
    public int SceneToLoad;

    private void Start()
    {
//------------------(Get Certian Component)------------------
        OptionsMenu = OptionsMenu.GetComponent<Canvas>();
        CreditsMenu = CreditsMenu.GetComponent<Canvas>();
        //-----------------------------------------------------------
        OptionsMenu.enabled = false;
        CreditsMenu.enabled = false;
        PlayButton.enabled = true;
        OptionsButton.enabled = true;
        CreditsButton.enabled = true;
        ExitButton.enabled = true;
    }
    public void Play()
    {
        SceneManager.LoadScene(SceneToLoad);
    }
    public void Options()
    {
        OptionsMenu.enabled = true;
        CreditsMenu.enabled = false;
        PlayButton.enabled = false;
        OptionsButton.enabled = false;
        CreditsButton.enabled = false;
        ExitButton.enabled = false;
    }
    public void Credits()
    {
        OptionsMenu.enabled = false;
        CreditsMenu.enabled = true;
        PlayButton.enabled = false;
        OptionsButton.enabled = false;
        CreditsButton.enabled = false;
        ExitButton.enabled = false;
    }
    public void Exit()
    {
        Application.Quit();
    }
    public void Back() {  
        OptionsMenu.enabled = false;
        CreditsMenu.enabled = false;
        PlayButton.enabled = true;
        OptionsButton.enabled = true;
        CreditsButton.enabled = true;
        ExitButton.enabled = true;

    }

    public void ChangeQuality(int q) {
        QualitySettings.SetQualityLevel(q);
    }

}
