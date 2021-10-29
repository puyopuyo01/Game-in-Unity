using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.UI;
using Finish_Game;
using Hand;
using Win_Lose;
using Flag;

namespace State{
	/*じゃんけん結果を処理する状態クラス*/
	public class Activity:Battle{
		Winner_Loser First;
		Winner_Loser Second;
		two_flag animation;
		GameObject first;
		GameObject second;
		GameObject[] determ=new GameObject[2];
		
		public void init(){
		}
			
		public Battle update(){
			First=BattleState.First_Player.determ.win_or_lose(BattleState.Second_Player.determ);
			Second=BattleState.Second_Player.determ.win_or_lose(BattleState.First_Player.determ);
			First.Win_Lose_Process(BattleState.First_Player,BattleState.Second_Player);
			Second.Win_Lose_Process(BattleState.Second_Player,BattleState.First_Player);
			stage();
			animation=new two_flag();
			animation.init();
			first.GetComponent<Active_Result>().init(animation,0,First.Result,determ[0]);
			second.GetComponent<Active_Result>().init(animation,1,Second.Result,determ[1]);
			return new Wait_anim(new Damage_stage(new Finish_Check(new Next_Prepare(new Next_Prepare(new Enhance_Excution(),BattleState.Second_Player),BattleState.First_Player))),animation as inter_Animation);
		}
		
		void stage(){ /*画面に映すオブジェクトを生成する*/
			determ[0]=UnityEngine.Object.Instantiate((GameObject)Resources.Load("Result/Determ"),new Vector2(-400,70),Quaternion.identity);
			determ[1]=UnityEngine.Object.Instantiate((GameObject)Resources.Load("Result/Determ"),new Vector2(-60,70),Quaternion.identity);
			determ[0].GetComponent<Determpanel>().init(BattleState.First_Player.determ);
			determ[1].GetComponent<Determpanel>().init(BattleState.Second_Player.determ);
			first=UnityEngine.Object.Instantiate((GameObject)Resources.Load("Result/Result_Obj"),new Vector2(-410,40),Quaternion.identity);
			second=UnityEngine.Object.Instantiate((GameObject)Resources.Load("Result/Result_Obj"),new Vector2(-70,40),Quaternion.identity);
			first.GetComponent<Animator>().SetBool("start",true);
			second.GetComponent<Animator>().SetBool("start",true);;
		}
	}
}