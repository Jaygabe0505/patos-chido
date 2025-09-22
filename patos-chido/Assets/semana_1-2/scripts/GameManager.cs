using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public GameObject ImagePausa;
    public GameObject DefeatImage;

    // Start is called before the first frame update
    void Start()
    {
        Time.timeScale = 1;
    }

    // Update is called once per frame
    void Update()
    {

    }


    public void Salir()
    {
        Application.Quit();
        Debug.Log("Cerrando...");
    }
    public void Pausa()
    {
        ImagePausa.gameObject.SetActive(true);
        Time.timeScale = 0;
    }

    public void Reanudar()
    {
        ImagePausa.gameObject.SetActive(false);

        Time.timeScale = 1;
    }

    public void Defeat()
    {
        DefeatImage.SetActive(true);
        Time.timeScale = 0;
    }

    public void Retry()
    {
        int actualScene = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(actualScene);
    }

    public void Victory()
    {
        SceneManager.LoadScene("SceneVictory");
    }

    public void MainMenu()
    {
        SceneManager.LoadScene("portada");
    }

    public void StartGame()
    {
        SceneManager.LoadScene("NivelFinal");
    }
}
