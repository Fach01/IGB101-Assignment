using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public GameObject player;


    //Pickup and Level Completion Logic
    public int currentPickups = 0;
    public int maxPickups = 13;
    public bool levelComplete = false;
    public Text pickupText;

    void Start()
    {
   
    }

    // Update is called once per frame
    void Update()
    {
       LevelCompleteCheck();
       UpdateGUI();
        
    }
    private void LevelCompleteCheck()
    {
        if (currentPickups >= maxPickups)
        {
            levelComplete = true;
        }
        else
        {
            levelComplete = false;
        }
    }

    private void UpdateGUI()
    {
        pickupText.text = "Pickups:" + currentPickups + "/" + maxPickups;
    }
}
