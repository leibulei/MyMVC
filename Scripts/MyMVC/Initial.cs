using UnityEngine;
using System.Collections;
namespace AssemblyCSharp
{
	public class Initial : MonoBehaviour {
		Controller con;
		void Start () {
			con = new Controller ();
//			Invoke ("hide", 2);

		}
		public void show(){
			con.show ();
		}
		public void hide(){
			con.hide ();
		}
	}
}

