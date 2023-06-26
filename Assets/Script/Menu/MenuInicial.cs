using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;

public class MenuInicial : MonoBehaviour
{
    public AudioSource clip;
    public void jugar()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void salir()
    {
        Debug.Log("Saliendo...");
        Application.Quit();
    }

    public void playSoundButton()
    {
        clip.Play();
    }
}
