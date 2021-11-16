using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MenuContoller : MonoBehaviour
{

    [SerializeField]
    private Button play;

    [SerializeField]
    private Button quit;


    private void Start()
    {

        play.onClick.AddListener(LoadLevel);

        quit.onClick.AddListener(QuitGame);

    }



    void LoadLevel()
    {
        SceneManager.LoadScene("Level1");
    }

    void QuitGame()
    {
        Application.Quit();
    }
}
