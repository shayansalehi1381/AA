using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    private bool gameHasEnded = false;

    public Rotator rotator;

    public Spawner spawner;

    public Animator animator;

    public void EndGame()
    {

        if (gameHasEnded)
            return;

        rotator.enabled = false;
        spawner.enabled = false;

        animator.SetTrigger("EndGame");

        //make the main camera back ground color to Red
        Camera.main.backgroundColor = Color.red;

        gameHasEnded = true;
     
    }




    public void RestartGame()
    {
       // Camera.main.backgroundColor = Color.white;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);

    }
}
