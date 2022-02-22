using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GlowOnHover : MonoBehaviour
{
    public void onHover(){
        GetComponent<Renderer>().material.EnableKeyword("_EMMISION");
    }
    public void offHover(){
        GetComponent<Renderer>().material.DisableKeyword("_EMMISION");
    }
}
