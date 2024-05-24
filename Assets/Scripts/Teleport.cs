using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleport : MonoBehaviour
{
   public Transform otherportal;
   private void OnTriggerEnter(Collider otherObject)
   {
	   if(otherObject.transform.tag == "Player"){
		   otherObject.gameObject.transform.position = otherportal.position;
	   }
   }
}
