using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using State;
using Hand;
using Character;

namespace Schemes{

	public class Change_fatgue_injury_Scheme : Scheme{	//ステータスを変化させる必殺技。値を変えるだけの必殺技は全てこのクラス。
		Player_Status player;
		List<Judge> hand;
		string name;
		string disc;
		int mol;
		int add_force;
		int fatigue;
		int injury;
		public string Name{
			get{return name;}
		}
		
		public string discription{
			get{return disc;}
		}
		
		public string disc_stage{
			get{return disc;}
		}
		
		public int morale{
			get{return mol;}
		}
		
		public Change_fatgue_injury_Scheme(Player_Status me,List<Judge> judge,string name,string disc,int morale,int force,int add_fatigue,int add_injury){
		/*me変数は、必殺技の対象となるキャラクタ*/
			hand=judge;
			this.add_force=force;
			this.name=name;
			this.disc=disc;
			this.mol=morale;
			this.hand=judge;
			this.fatigue=add_fatigue;
			this.injury=add_injury;
			player=me;	
		}
		
		public void scheme(){
			foreach(Judge judge in hand){
				judge.fatigue+=fatigue;
				judge.injury+=injury;
				judge.pass_force+=add_force;
			}
			player.Morale-=morale;
		}
	}
}
