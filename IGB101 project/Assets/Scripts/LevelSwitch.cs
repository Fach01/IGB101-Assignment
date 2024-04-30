using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelSwitch : MonoBehaviour
{
    GameManager gameManager;
    public string nextLevel;
    private void Start()
    {
        gameManager = GameObject.FindGameObjectWithTag("GameManager").GetComponent<GameManager>();
    }
    private void OnTriggerEnter(Collider otherObject)
    {
        if(otherObject.tag == "Player")
        {
            if (gameManager.levelComplete)
            {
                SceneManager.LoadScene(nextLevel);
            }
        }
    }
}
