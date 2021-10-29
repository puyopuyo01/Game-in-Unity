using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;
using UnityEngine.UI;
using Character;

namespace character_select{

	public class Momo_Story : Hero{
			Dictionary<int,TextAsset> talk=new Dictionary<int,TextAsset>()
			{
				{1,Resources.Load("Text/Ryubi/Ryubi1")as TextAsset},
				{2,Resources.Load("Text/Ryubi/Ryubi2")as TextAsset},
				{3,Resources.Load("Text/Ryubi/Ryubi3")as TextAsset},
				{4,Resources.Load("Text/Ryubi/Ryubi4")as TextAsset},
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
					{1,new Ai("enemy")},
					{2,new Hatsu("enemy")},
					{3,new Jin("enemy")},
					{4,new Chuei("enemy")},
				};
				return enemy[Stage.stagenum];
			}
		}
		
		public Player_Status hero{
			get{return new Momo("player");}
		}

	}
}
