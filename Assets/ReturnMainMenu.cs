using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ReturnMainMenu : MonoBehaviour
{
    // Start is called before the first frame update

    public void BAckMainMenu()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
    }

    // Update is called once per frame
    public void QuitGame()
    {
        // Debug.log("QUIT!");
        Application.Quit();
    }
}
