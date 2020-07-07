using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : Singleton<GameController>
{
    // private GameObject panel;

    public void WinGame()
    {
        GameObject.FindGameObjectWithTag("WinPanel").SetActive(true);
    }

    public void LoseGame()
    {
        GameObject.FindGameObjectWithTag("LosePanel").SetActive(true);
    }

    public void ResetGame()
    {
        ScoresController.Instance.ResetScore();
        BagsController.Instance.ResetBags();
    }
}
