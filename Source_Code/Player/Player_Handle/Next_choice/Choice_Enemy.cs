using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;
using System.Linq;
using State;
using Hand;
using Character;

namespace Handle{

	public class Choice_Enemy : Next_Choice_Handler{
		int level;
		Player_Status operate;
		Player_Status enemy;
		System.Random rnd;
		
		public Choice_Enemy(Player_Status operate,int level){
			this.level=level;
		    rnd=new System.Random();
			this.operate=operate;
		}
		
		public void init(){
			operate.Sel_Next=new List<Judge>();
		}
		
		
		public void init(Player_Status enemy){
			this.enemy=enemy;
		}
		
		
		public Battle update(Battle prev,Battle next){
			if(level==1){
				List<Judge> judge=force_sort(enemy.hand);
				operate.Sel_Next.Add(operate.hand[judge[0].Lose_ID]);
				operate.Sel_Next.Add(operate.hand[judge[1].Lose_ID]);
				operate.Sel_Next.Add(operate.hand[judge[2].Lose_ID]);
			}
			else if(level==0){
				random();	//完全ランダム
			}
			next.init();
			return next;
		}
		
		List<Judge> force_sort(Judge[] judge){
			int i,j;
			Judge pivot;
			Judge[] list=new Judge[5];
			judge.CopyTo(list,0);
			
			for(i=0;i<list.Length;i++){		//相手の魔力が高い順にソート(クイックソート)。敵の魔力が高い属性に相性勝ちできる手を選択
				pivot=list[i];
				for(j=i;j<list.Length;j++){
					if(list[j].pass_force>pivot.pass_force){
						list[i]=list[j];
						list[j]=pivot;
						pivot=list[i];
					}
				}
			}
			return list.ToList();
		}
		
		void random(){
			operate.Sel_Next=new List<Judge>();
			foreach(Judge judge in operate.hand){
				operate.Sel_Next.Add(judge);
			}
			while(operate.Sel_Next.Count>3){
				operate.Sel_Next.RemoveAt(rnd.Next(operate.Sel_Next.Count));
			}
		}

	}
}
