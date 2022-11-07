using System;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuController : MonoBehaviour
{
    public string Scene;
    public GameObject MenuPrincipal;
    public GameObject MenuCongigurações;

    //metodo para iniciar o jogo
    public void StartGame()
    {
        SceneManager.LoadScene(Scene);
    }

    //metodo para entrar no menu de configurações
    public void OpenConfigMenu()
    {
        MenuPrincipal.SetActive(false);
        MenuCongigurações.SetActive(true);
    }


    //metodo para fechar as configurações
    public void CloseConfigMenu()
    {
        MenuCongigurações.SetActive(false);
        MenuPrincipal.SetActive(true);
    }

    //metodo para sair do jogo
    public void ExitGame()
    {
        print("Finanlizando jogo");
        Application.Quit();
    }
}
