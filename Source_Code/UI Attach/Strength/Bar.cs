using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using UnityEngine;
using UnityEngine.UI;
using Flag;

namespace State{

	public class Bar : MonoBehaviour{
	//体力バーの処理
	    public async void set(two_flag finish,int HP,int num){
	    	GetComponent<Slider>().value=HP;
	    	await Task.Delay(1000);
			if(num==0){ 
				finish.first_notif=true;
			}
			
			if(num==1){
				finish.second_notif=true;
			}
	    }
	   
	}
}
