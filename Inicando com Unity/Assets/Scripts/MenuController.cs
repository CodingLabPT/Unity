using System;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuController : MonoBehaviour
{
    public string Scene;
    public GameObject MenuPrincipal;
    public GameObject MenuCongigura��es;

    //metodo para iniciar o jogo
    public void StartGame()
    {
        SceneManager.LoadScene(Scene);
    }

    //metodo para entrar no menu de configura��es
    public void OpenConfigMenu()
    {
        MenuPrincipal.SetActive(false);
        MenuCongigura��es.SetActive(true);
    }


    //metodo para fechar as configura��es
    public void CloseConfigMenu()
    {
        MenuCongigura��es.SetActive(false);
        MenuPrincipal.SetActive(true);
    }

    //metodo para sair do jogo
    public void ExitGame()
    {
        print("Finanlizando jogo");
        Application.Quit();
    }
}
