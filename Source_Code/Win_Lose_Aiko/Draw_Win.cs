using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Hand;
using State;
using Character;

/*魔力値で勝利した場合の処理。疲労度に応じて魔力値が減少する。*/
namespace Win_Lose{
	public class Draw_Win :W_L,Winner_Loser{
		int fatigue,injury;
		public Draw_Win(string res){
			result=res;
		}

		public virtual void Win_Lose_Process(Player_Status me,Player_Status enem){
			process(me,enem);
		}
		
		protected void process(Player_Status me,Player_Status enem){
			enem.HP-=(int)me.RATE/2;
			foreach(Judge judge in me.wait_sel){
				if(me.determ.pass_ID!=judge.pass_ID){	//選択しなかった手は、「次ターンの魔力値」=(「現在の魔力値」/2)-疲労度
					judge.pass_force-=(judge.fatigue/2);
				}
			}
			me.determ.pass_force-=me.determ.fatigue;	//選択した手は、「次ターンの魔力値」=現在の魔力値-疲労度
			foreach(Judge judge in me.hand){
				judge.fatigue+=1;
			}
			me.determ.fatigue+=1; //選択した手は、さらに疲労度を+1する。
			Add(me,add_fatigue,add_injury,add_HP);	//状態によって、ステータスが変わる
			Add(enem,add_fatigue_enem,add_injury_enem,add_damage_enem);
		}
		
	}
}
