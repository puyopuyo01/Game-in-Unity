using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;
using UnityEngine.UI;
using State;
using Character;

/*じゃんけんの結果を処理をするクラス
さまざまな状態があり、それに応じて処理を変える*/

namespace Win_Lose{
/*じゃんけんの結果を処理するインタフェース。*/
	public interface Winner_Loser{
		void Win_Lose_Process(Player_Status me,Player_Status enem); //この関数で処理を行う。
		void Add_Value(int fatigue,int injury,int enem_fatigue,int enem_injury,int HP,int damage_enem);
		string Result{
			get;
		}
	}
			
	public class W_L{
	/*じゃんけんの結果のクラスの共通処理*/
		protected int add_fatigue,add_injury,add_fatigue_enem,add_injury_enem,add_HP,add_damage_enem;
		protected string result;
		
		public W_L(){
			add_fatigue=0;
			add_injury=0;
			add_fatigue_enem=0;
			add_injury_enem=0;
			add_HP=0;
			add_damage_enem=0;
		}
		
		public void Add_Value(int fatigue,int injury,int enem_fatigue,int enem_injury,int HP,int damage_enem){
			add_fatigue=fatigue;
			add_injury=injury;
			add_fatigue_enem=enem_fatigue;
			add_injury_enem=enem_injury;
			add_HP=HP;
			add_damage_enem=damage_enem;
		}
		
		protected void Add(Player_Status player,int fatigue,int injury,int HP){
			player.determ.fatigue+=fatigue;
			player.determ.injury+=injury;
			player.HP+=HP;	
		}
	
	
		
		public string Result{
			get{return result;}
		}

	}
}
