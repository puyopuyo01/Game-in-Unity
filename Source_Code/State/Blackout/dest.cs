using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dest : MonoBehaviour
{
    void Update()
    {
        transform.SetAsLastSibling();
    }
    
    public void On(){
    	Destroy(gameObject);
    }
}
