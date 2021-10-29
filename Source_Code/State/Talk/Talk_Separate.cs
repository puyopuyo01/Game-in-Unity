using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;
using UnityEngine.UI;

namespace String_Separate{
/*テキストファイルの文章を行と列(スペース)で区別し、配列に格納させる処理を行うクラス。*/
	public class Talk_Separate{
		int i,j;
		public string[,] Separate(TextAsset text){ //スペース区切りが1つの場合の処理。
			string[,] ret_str;
			string[] row; 
			string overroll=text.text;
			row=overroll.Split('\n');
			
			ret_str=new string[row.Length,row[0].Split(' ').Length];
			for(i=0;i<row.Length-1;i++){
				string[] word=row[i].Split(' ');
				for(j=0;j<row[0].Split(' ').Length;j++){
					ret_str[i,j]=word[j];
				}
			}
			return ret_str;
		}
		
		public string[] separate_one(TextAsset text,int ID){ //列のスペース区切りが複数ある場合、「ID」列番目の行のテキストを取り出す。
			string overroll=text.text;
			string[] row=overroll.Split('\n');
			string[] lenght=new string[row.Length];
			for(i=0;i<row.Length;i++){
				lenght[i]=row[i].Split(' ')[ID];
			}
			return lenght;
		}
		
		public int row(TextAsset textasset){ //行数算出
			string overroll=textasset.text;
			string[] row=overroll.Split('\n');
			return row.Length;
		}

	}
}
