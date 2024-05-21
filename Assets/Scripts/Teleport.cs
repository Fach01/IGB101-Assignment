using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleport : MonoBehaviour
{
   public Transform otherportal;
   private void OnTriggerEnter(Collider otherObject)
   {
	   if(otherObject.transform.tag == "Player"){
		   Debug.Log("KILLLL MEEEEEE");
		   otherObject.gameObject.Transform.position = otherportal.position;
	   }
   }
}
