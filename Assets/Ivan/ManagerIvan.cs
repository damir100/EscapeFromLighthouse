using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ManagerIvan : MonoBehaviour
{
     public void StartGame()
    {
        SceneManager.LoadScene("prprp");
    }

    public void QuitGame()
    {
        Application.Quit();
        Debug.Log("Kao ono izasao si iz igre ziher !");
    }

}
