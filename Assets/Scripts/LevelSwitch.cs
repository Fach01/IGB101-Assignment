using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelSwitch : MonoBehaviour
{
    GameManager gameManager;
    public string nextLevel;
    public AudioSource sfx;

    private void Start()
    {
        gameManager = GameObject.FindGameObjectWithTag("GameManager").GetComponent<GameManager>();
    }
    
    private void OnTriggerEnter(Collider collider) {
        if (collider.transform.tag == "Player") {
            if (gameManager.levelComplete) {
                StartCoroutine(PlaySFXAndLoadNextScene());
                
            }
        }
    }

    private IEnumerator PlaySFXAndLoadNextScene() {
        
        if (sfx != null) {
            sfx.Play();
            yield return new WaitForSeconds(4);
        }

        SceneManager.LoadScene(nextLevel);
    }
}
