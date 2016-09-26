using System;
using UnityEngine;
namespace AssemblyCSharp
{
	public class Data
	{
		public event EventHandler TakingDamage;
		public event EventHandler Died;
		public event EventHandler LevelUp;
		public event EventHandler GainedExp;
		public float hp;
		public Data ()
		{
			Exp = 0;
			Level = 1;
			HP = MaxHp;


		}
		public float Exp{ get; private set;}
		public float Level{get;private set;}
		public float HP {
			get{ return  hp;}
			set{ hp=value;
				if (IsDead) {
					hp = 0;
					if (Died!=null) {
						Died (this, new EventArgs ());
					}
				}else if (TakingDamage != null)
					TakingDamage(this, EventArgs.Empty);
			}
		}
		public float MaxExp{get{ return Level * 100;}}
		public float MaxHp{ get { return Level * 150; }}
		public bool HasLowHp{get{ return hp<= MaxHp * 0.25f;}}
		public bool IsDead{get{ return hp <= 0;}}
		public void TakeDamage(float damage){
			if (IsDead)return;
			HP -= damage;
		}
		public void GainExp(float exp){
			if (IsDead)return;
			Exp += exp;
			if (GainedExp!=null) {
				GainedExp (this, new EventArgs ());
			}
			if (Exp>=MaxExp) {
				UpLevel ();
			}
		}
		public void UpLevel(){
			if (IsDead)return;
			Level++;
			HP = MaxHp;
			Exp = 0;
			if (LevelUp!=null) {
				LevelUp (this, new EventArgs ());
			}
		}
	}
}

