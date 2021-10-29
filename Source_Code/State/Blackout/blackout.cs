using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Black_Out;
using Flag;

namespace State{

	public class blackout : MonoBehaviour{
	/*暗転時の処理。
	画面が暗くなったらvalset関数を呼び出して画面の値を更新。*/
		one_flag anim;
		blackout_game game;
	    void Start()
	    {
	         transform.SetParent(GameObject.Find("Canvas").transform,false);
	    }
	    
	    public void init(one_flag anim,blackout_game game){
	    	this.anim=anim;
	    	this.game=game;
	    }
	    
	    public void init(blackout_game game){
	    	this.game=game;
	    }
	    
	    public void valset(){
	    	game.update();
	    }
	    
	    public void notif(){
	    	if(anim==null){	Destroy(this.gameObject);	return; }
	    	anim.first_notif=true;
	    	Destroy(this.gameObject);
	    }
	}
}
