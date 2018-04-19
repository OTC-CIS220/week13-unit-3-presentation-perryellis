using UnityEngine;
using UnityEngine.SceneManagement;

/// <summary>
/// Developer:  Perry Ellis
/// Program:    Stay alive
/// Purpose:    Kill or be killed
/// Date:       4/17/2018
/// </summary>
public class GameOverManager : MonoBehaviour
{
    public PlayerHealth playerHealth;       
    public float restartDelay = 5f;         


    Animator anim;                          
    float restartTimer;                     


    void Awake()
    {
        // Set up the reference.
        anim = GetComponent<Animator>();
    }


    void Update()
    {
        // If the player has run out of health...
        if (playerHealth.currentHealth <= 0)
        {
            // ... tell the animator the game is over.
            anim.SetTrigger("GameOver");

            // .. increment a timer to count up to restarting.
            restartTimer += Time.deltaTime;

            // .. if it reaches the restart delay...
            if (restartTimer >= restartDelay)
            {
                // .. then reload the currently loaded level.
                Application.LoadLevel(Application.loadedLevel);
                //SceneManager.LoadScene(SceneManager.LoadScene);
            }
        }
    }
}