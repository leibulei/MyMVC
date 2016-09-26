using System;
using UnityEngine;
namespace AssemblyCSharp
{
	public class Controller
	{
		public Data data{ get; set;}
		public View view{ get; set;}
		public Controller ()
		{
			data = new Data ();
			view = GameObject.Find ("MainUI").GetComponent<View>();
			view.TakeDamageBtnView.BtnClick += (s,e) => {
				Debug.Log("TakeDamageBtn Clilck");
				data.TakeDamage (10);
			};
			view.AddExpBtnView.BtnClick += (s,e) => {
				Debug.Log("AddExpBtn Clilck");
				data.GainExp (20);
			};
			data.TakingDamage += TakeingDamage;
			data.Died += Died;
			data.LevelUp += LevelUp;
			data.GainedExp += GainedExp;
			UpdateHp ();
			UpdateExp ();
			UpdateLevel ();
		}
//		public event EventHandler TakeingDamage;
//		public event EventHandler Died;
//		public event EventHandler LevelUp;
//		public event EventHandler GainedExp;
		public void TakeingDamage(object sender, EventArgs args){
			UpdateHp ();
		}
		public void Died(object sender, EventArgs args){
			view.HpLabView.Text = "You are deaded!";
			view.HpLabView.TextColor = UnityEngine.Color.red;
		}
		public void LevelUp(object sender, EventArgs args){
			UpdateExp ();
			UpdateLevel ();
		}
		public void GainedExp(object sender, EventArgs args){
			UpdateExp ();
		}
		public void UpdateHp(){
			view.HpLabView.Text = "HP: "+data.HP.ToString();
			if (data.HasLowHp) {
				Debug.Log ("LowHP!!!");
				view.HpLabView.TextColor = UnityEngine.Color.yellow;
			} else {
				view.HpLabView.TextColor = UnityEngine.Color.black;
			}
		}
		public void UpdateExp(){
			view.ExpLabView.Text = "EXP: " + data.Exp.ToString ();
		}
		public void UpdateLevel(){
			view.LevelLabView.Text = "LEVEL: " + data.Level.ToString ();
		}
		public void show(){
			view.show ();
		}
		public void hide(){
			view.hide ();
		}
	}
}

