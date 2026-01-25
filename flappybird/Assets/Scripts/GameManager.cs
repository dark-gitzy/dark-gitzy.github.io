using UnityEngine;

using UnityEngine.UI;


public class GameManager: MonoBehaviour
{
public PlayerMovement player ;

public Text scoreText;



public GameObject playButton;



public GameObject gameOver;



private int score;



private void Awake()
    {
        Application.targetFrameRate = 60;
        Pause();
    }

    public void Play()
{
    score = 0;
    scoreText.text = score.ToString();
    playButton.SetActive(false);
    gameOver.SetActive(false);
    
    Time.timeScale = 1f;
    player.enabled = true;

    // Use the modern FindObjectsByType to get ALL pipes currently on screen
    // We use 'Pipe' (capital P) because that is your class name
    Pipe[] allPipes = Object.FindObjectsByType<Pipe>(FindObjectsSortMode.None);

    for (int i = 0; i < allPipes.Length; i++) {
        Destroy(allPipes[i].gameObject);
    }
}

    public void Pause()
    {
        Time.timeScale = 0f;
        player.enabled = false;
    }

public void Gameover()
    {
    gameOver.SetActive(true);
    playButton.SetActive(true);
    Pause();

    }



public void IncreaseScore()
    {
        score++;
        scoreText.text = score.ToString();  
    }

}

