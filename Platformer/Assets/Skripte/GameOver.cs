using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{
    bool krajIgre = false;
    public void gameOver()
    {
        if (krajIgre == false)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
            krajIgre = true;
        }
    }
}
