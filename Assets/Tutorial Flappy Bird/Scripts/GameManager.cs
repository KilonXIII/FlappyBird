using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    static public GameManager instace;

    public GameObject gameOverUI;
    public Text scoreUI;
    public float scrollSpeedXMultiple;
    // Start is called before the first frame update
    private void Awake()
    {
        instace = this;
        ShowGameOver(false);
    }

    // Update is called once per frame
    bool isGameOver = false;


    internal void SetGameOver()
    {
        isGameOver = true;
        ShowGameOver(true);
    }

    private void Update()
    {
        if (isGameOver)
        {
            if (Input.GetKeyDown(KeyCode.Space) || Input.GetKeyDown(KeyCode.Mouse0))
            {

                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);

            }
        }
    }

    internal  void ShowGameOver(bool active)
    {
        gameOverUI.SetActive(active);
    }

    int score;
    internal float scrollSpeedXMultiply = 1;

    internal void AddScore()
    {
        score += 100;
        scoreUI.text = "Score :" + score;
    }

   
}



