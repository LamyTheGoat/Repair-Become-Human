﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManagerScript : MonoBehaviour
{

    public bool gameHasEnded = false;
    public GameObject levelCompleteUI;
    public GameObject levelEndUI;
    public GameObject explosion;
    public GameObject player;

    public float restartDelay = 1f;

    public void CompleteLevel() {
        gameHasEnded = true;
        Debug.Log("LEVEL COMPLETE!");
        levelCompleteUI.SetActive(true);
    }

    public void EndGame()
    {
        
            Instantiate(explosion, player.transform.position, player.transform.rotation);
            player.SetActive(false);
        
        if (gameHasEnded == false)
        {
            gameHasEnded = true;
            Debug.Log("Game Over");
            levelEndUI.SetActive(true);
            Invoke("Restart", restartDelay);
        }
    }
    void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
