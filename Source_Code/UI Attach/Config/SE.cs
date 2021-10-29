using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using config;

public class SE : MonoBehaviour
{
    // Update is called once per frame
    void Update(){
        if(GetComponent<AudioSource>().volume!=Config.SE){
        	GetComponent<AudioSource>().volume=Config.SE;
        }
    }
}
