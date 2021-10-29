using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Schemes;
using Hand;
using State;
using Character;

namespace Schemes{

	public class Enhance_Scheme:Scheme{
		Player_Status player;
		List<Judge> judge;
		int mol;
		int add;
		string name;
		string discr;
		
		public string Name{
			get{return name;}
		}
		
		public string discription{
			get{return discr;}
		}
		
		public string disc_stage{
			get{return discr;}
		}
		public int morale{
			get{return mol;}
		}
		
	    
		
		public Enhance_Scheme(Player_Status player,List<Judge> judge,int add,string disc,string name,int morale){
			this.player=player;
			this.judge=judge;
			this.add=add;
			this.mol=morale;
			this.name=name;
			this.discr=disc;
		}
		
		public void scheme(){
			foreach(Judge judge in judge){
				judge.pass_force+=add;
			}
			player.Morale-=morale;
		}

	}
}
