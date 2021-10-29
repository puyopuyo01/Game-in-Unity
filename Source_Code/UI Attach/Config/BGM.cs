using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using config;

public class BGM : MonoBehaviour
{

    // Update is called once per frame
    void Update(){
        if(GetComponent<AudioSource>().volume!=Config.BGM){
        	GetComponent<AudioSource>().volume=Config.BGM;
        }
    }
}
