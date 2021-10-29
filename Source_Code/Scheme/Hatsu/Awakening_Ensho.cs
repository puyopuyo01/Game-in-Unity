using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Hand;
using continuate;
using Character;

namespace Schemes{

	public class Awakening_Ensho : continuation_base,Scheme,continuation{
		List<Judge> used=new List<Judge>();
		public string Name{
			get{return "大攻勢魔法";}
		}
		
		public string discription{
			get{return "全属性の魔力値を上げ、4ターンの間「攻勢」状態にする(追加ダメージ200)。\nただし、4ターンの間に選択した属性はその後「負傷」状態になる。\n"+ State_discription.discription("offensive");}
		}
		
		public string disc_stage{
			get{return "全属性の魔力値を上げ、4ターンの間「攻勢」状態にする(追加ダメージ200)。ただし、4ターンの間に選択した属性はその後「負傷」状態になる。";}
		}
		
		public int morale{
			get{return 6;}
		}
		
		public Awakening_Ensho(Player_Status me){
			finish=false;
			elapsed=0;
			player=me;
		}
		
		public void scheme(){
			player.scheme_use.Add(this);
			foreach(Judge judge in player.hand){
				judge.pass_force+=8;
				judge.Stack(new Hand_Offensive(judge,-200));
			}
			used.Add(player.determ);
			player.Morale-=morale;
		}
		
		public void update_scheme(){
			elapsed++;
			if(Duplicate()){used.Add(player.determ);}
			if(elapsed>=4){
				finish=true;
				Hand_Pop_All();
				foreach(Judge judge in used){
					judge.Stack(new Hand_Injury(judge));
				}
				
			}
		}
		
		bool Duplicate(){
			foreach(Judge judge in used){
				if(judge.pass_ID==player.determ.pass_ID){ return false; }
			}
			return true;
		}
		
		public bool Finish{
			get{return finish;}
		}
	}
}
