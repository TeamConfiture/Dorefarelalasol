using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class main_menu : MonoBehaviour
{
    public GameObject MainMenu;
    public GameObject CreditsMenu;
    public AudioSource soundEffect;

    public AudioClip click;
    public AudioClip hover;


    // Start is called before the first frame update
    public void Start()
    {

    }

    public void PlayNowButton(string scene) {
        UnityEngine.SceneManagement.SceneManager.LoadScene(scene);
        if (soundEffect != null)
        {
            soundEffect.Play();
        }
        
    }
    public void CreditsButton() {
        CreditsMenu.SetActive(true);
        MainMenu.SetActive(false);
        if (soundEffect != null)
        {
            soundEffect.Play();
        }
        
    }
    public void MainMenuButton() {
        MainMenu.SetActive(true);
        CreditsMenu.SetActive(false);
    }
    public void BackButton(){
        MainMenu.SetActive(true);
        CreditsMenu.SetActive(false);
        if (soundEffect != null)
        {
            soundEffect.Play();
        }
        
    }
    public void QuitButton() {
        Application.Quit();
    }

    public void HoverSound()
    {
        soundEffect.PlayOneShot(hover);
    }
    
}