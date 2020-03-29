using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Play_again : MonoBehaviour
{
    public GameObject gameover;
    public GameObject Win;
    // Start is called before the first frame update
   public void Reset_Game()
    {
        Debug.Log("play");
        ScoreTextScripte.coinAmount = 0;
        gameover.SetActive(false);
        SceneManager.LoadScene("main");
    }
    public void Win_reset()
    {
        ScoreTextScripte.coinAmount = 0;
        Win.SetActive(false);
        SceneManager.LoadScene("main");
    }
}
