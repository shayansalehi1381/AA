using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    private bool gameHasEnded = false;

    public void EndGame()
    {

        if (gameHasEnded)
            return;

        gameHasEnded = true;
        Debug.Log("End Game");
    }
}
