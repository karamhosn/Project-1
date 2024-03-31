using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; // Access the UI with more functionality
using UnityEngine.SceneManagement; // Ability to manage scene (for restartGame function)

public class LogicScript : MonoBehaviour
{
    // No need for Start() or Update()

    public int playerScore; // Create an integer to store player's score
    
    // Create a reference to UI text (available through UnityEngine.UI)
    // And drag and drop Text(Legacy) into reference variable
    public Text scoreText;

    // Create reference to "Game Over" screen to use
    // in gameOver() function
    // Fill in the reference in Unity
    public GameObject gameOverScreen;

    // Context Menu's are handy for testing functions
    [ContextMenu("Increase Score")] // Allows us to run addScore from Unity
    public void addScore(int scoreToAdd)
    {
        // Increments player score by 1
        // Makes text on UI equal to new player score
        playerScore = playerScore + scoreToAdd;
        scoreText.text = playerScore.ToString();
    }

    // Function to run when "Play Again" button is pressed
    public void  restartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    // Game over function
    public void gameOver()
    {
        gameOverScreen.SetActive(true);
    }

}
