using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Character;

namespace character_select{

	public class Ai_Story : Hero{
			Dictionary<int,TextAsset> talk=new Dictionary<int,TextAsset>()
			{
				{1,Resources.Load("Text/Sousou/sousou1")as TextAsset},
				{2,Resources.Load("Text/Sousou/sousou2")as TextAsset},
				{3,Resources.Load("Text/Sousou/sousou3")as TextAsset},
				{4,Resources.Load("Text/Sousou/sousou4")as TextAsset},
			};
	
		public TextAsset text_talk{
			get{
				return talk[Stage.stagenum];
			}
		}
				
	
		public Player_Status Enemy{
			get{
				Dictionary<int,Player_Status> enemy=new Dictionary<int,Player_Status>()
				{
					{1,new Momo("enemy")},
					{2,new Hatsu("enemy")},
					{3,new Jin("enemy")},
					{4,new Chuei("enemy")},
				};
				return enemy[Stage.stagenum];
			}
		}
		
		public Player_Status hero{
			get{return new Ai("player");}
		}

	}
}
