using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManage : MonoBehaviour
{
    public Text pointTextWin;
    public Text pointTextOver;

    public GameObject gameWin;
    public GameObject gameOver;

    [Header("Win Sound")]
    [SerializeField] private AudioClip winSound;
    [SerializeField] private AudioClip loseSound;
    public float point { get; private set; }
    public float currentPoint { get; private set; }

    public void Setup(float score)
    {
        gameOver.SetActive(true);
        pointTextOver.text = score.ToString() + " POINTS";
        SoundManager.instance.PlaySound(loseSound);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        point = PlayerPrefs.GetFloat("Points", currentPoint);
        if (collision.tag == "Player" && point == 12)
        {
            gameWin.SetActive(true);
            Debug.Log(point);
            pointTextWin.text = point.ToString() + " POINTS";
            SoundManager.instance.PlaySound(winSound);
        }
    }
    public void reStart()
    {
        SceneManager.LoadScene(1);
    }
    public void backToMenu()
    {
        SceneManager.LoadScene(0);
    }
}
