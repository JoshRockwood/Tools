using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class MainMenu : MonoBehaviour
{
    public int sceneToLoad;
    public PlayAudio playAudio;
    // Start is called before the first frame update
    public void Start()
    {
        // Reference to AudioSource game object
        playAudio = GameObject.Find("AudioSource").GetComponent<PlayAudio>();
    }
    public void StartGame()
    {
        // Button click sound effect
        playAudio.startGame();
        // Scene to load
        SceneManager.LoadScene(sceneToLoad);
    }

    public void QuitGame()
    {
        // Button click sound effect
        playAudio.startGame();
        Application.Quit();
        Debug.Log("Quit Game!");
    }
}
