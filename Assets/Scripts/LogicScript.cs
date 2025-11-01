using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System;
using UnityEngine.SceneManagement;

public class LogicScript : MonoBehaviour
{
    public int PlayerScore;
    public TMP_Text scoreTMP;
    public GameObject gameOverScreen;
    public AudioSource dingSFX;
    private AudioClip dingClip;

    [ContextMenu("Increase Score")]
    public void addScore(int ScoreTOAdd)
    {
        PlayerScore = PlayerScore + ScoreTOAdd;
        scoreTMP.text = PlayerScore.ToString();
        if (dingSFX != null)
        {
            dingSFX.Play();
        }
    }
    public void restartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    void Start()
    {
        dingClip = Resources.Load<AudioClip>("sfx_point");
        if (dingSFX == null)
        {
            dingSFX = gameObject.AddComponent<AudioSource>();
        }
        dingSFX.clip = dingClip;
    }

    public void gameover()
    {
        gameOverScreen.SetActive(true);
    }
}
