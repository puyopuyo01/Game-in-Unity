using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Hand;
using Character;
using continuate;

namespace Schemes{

	public class True_Game : continuation_base,Scheme,continuation{
		int total_damage;
		int hp;
		public string Name{
			get{return "真向勝負";}
		}
		
		public string discription{
			get{return "3ターン後、選択できる属性の魔力値を上げ「攻勢」状態にする。（追加ダメージは3ターンの間に受けたダメージ量で決まる）\n"+ State_discription.discription("offensive");}
		}
		
		public string disc_stage{
			get{return "3ターン後、選択できる属性の魔力値を上げ「攻勢」状態にする。";}
		}
		public int morale{
			get{return 5;}
		}
		
		public True_Game(Player_Status me){
			finish=false;
			elapsed=0;
			total_damage=0;
			player=me;
		}
		
		public void scheme(){
			player.scheme_use.Add(this);
			hp=player.HP;
			player.Morale-=morale;
		}
		
		public void update_scheme(){
			elapsed++;
			total_damage+=(hp-player.HP);
			hp=player.HP;
			if(elapsed>=3){
				finish=true;
				foreach(Judge judge in player.wait_sel){
					judge.pass_force+=4;
					judge.Stack(new Hand_Offensive(judge,-(total_damage/3)));
				}
			}
		}
		
		public bool Finish{
			get{return finish;}
		}
	}
}
