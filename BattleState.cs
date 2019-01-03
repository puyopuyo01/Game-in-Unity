using B;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.UI;
using System.Threading.Tasks;
using System.Threading;
using System.Timers;
using System.IO;
using System.Linq;

namespace B{

	public interface Battle
	{
		Battle update();
		String ID{
			get;
		}
	}
	

	public partial class BattleState : MonoBehaviour {
		public static Player_Judge AP_Player;
		public static Player_Judge BP_Player;
		public Text[] tex = new Text[5];
		public static int stime;
		public static Judge c;
		public static Judge e;
		public static Judge p;
		public static Judge s; 
		private static string text_one;
		private static string tim;
		private static Battle actselect;
		private static Battle active;
		public static Battle startselect;
		private static Battle nextjudge;
		private static Battle battle;
		
		private void Render(){
		}
		
		private void create(){
			BattleState.startselect=new Select_Start();
			BattleState.actselect=new Act_Selection();
			BattleState.active=new Activity();
			BattleState.nextjudge=new Select_NextJudge();
			BattleState.battle=startselect;
			while(BattleState.battle.ID != "end"){
				BattleState.battle=BattleState.battle.update();
			}
			return ;

		}


		// Use this for initialization
		void Start () {
			BattleState.stime=10;
			BattleState.AP_Player=new Player("Man");
			BattleState.BP_Player=new Player("Man");
			BattleState.startselect=new Select_Start();
			BattleState.actselect=new Act_Selection();
			BattleState.active=new Activity();
			BattleState.nextjudge=new Select_NextJudge();
			BattleState.battle=startselect;
		}
		
		void Update(){
				BattleState.battle=BattleState.battle.update();
				tex[0].text=BattleState.text_one;
				tex[1].text=BattleState.stime.ToString();
		}
		
	}

	

	
}

