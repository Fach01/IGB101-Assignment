using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class DoorTest : MonoBehaviour
{
    Animation Door;
    public GameObject player;
    private bool hasplayed = false;
    public float mindistance = 1;
    // Start is called before the first frame update
    void Start()
    {
        Door = GetComponent<Animation>();
    }

    // Update is called once per frame
    void Update()
    {
        if (!hasplayed && Vector3.Distance(player.transform.position, transform.position) <= mindistance)
        {
            Door.Play();
            hasplayed = true;
        }
            
    }
}
