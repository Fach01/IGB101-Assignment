using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class LevelSwitch : MonoBehaviour
{      
    GameManager gameManager;
    public string nextLevel;


    // Start is called before the first frame update
    void Start()
    {
        if(gameManager != null) gameManager = GameObject.FindGameObjectWithTag("GameManager").GetComponent<GameManager>();
    }

    private void OnTriggerEnter(Collider otherObject)
    {
        if (otherObject.transform.tag == "Player")
        {
            if (gameManager.levelComplete)
            {
                switchscene();
            }
        }
    }
    public void switchscene()
    {
        SceneManager.LoadScene(nextLevel);
    }
    public void quit()
    {
        Application.Quit();
    }
}
