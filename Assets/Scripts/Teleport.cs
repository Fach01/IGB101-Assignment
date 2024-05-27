using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleport : MonoBehaviour
{
   public Transform otherportal;
	public GameObject player;
	public GameObject Camera;
   private void OnTriggerEnter(Collider otherObject)
   {
	   if(otherObject.transform.tag == "Player"){
		   player.transform.position = otherportal.transform.position;
	   }
   }
}
