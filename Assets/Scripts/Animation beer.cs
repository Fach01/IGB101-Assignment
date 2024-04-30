using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationBeer : MonoBehaviour
{
    public void ChangeMaterial(Material mat) // swaps the material of the particle sytem to mat
    {
        var Render = this.gameObject.GetComponent<Renderer>();
        Render.material = mat;
    }

    public void DoNothing()
    {

    }
        

}
