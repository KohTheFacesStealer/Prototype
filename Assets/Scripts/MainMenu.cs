using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

    public class MainMenu : MonoBehaviour
    {

        public void Continue()
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
            Time.timeScale = 1f;
            PauseMenu.GameIsPaused = false;
        }

        public void Quit()
        {
            Application.Quit();
        }


    }