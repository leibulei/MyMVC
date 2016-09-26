using UnityEngine;
using System;
using System.Collections;
public class BtnViewPresenter : MonoBehaviour {
	public UIButton btn;
	public event  EventHandler BtnClick;
	public void OnClick(){
		if (BtnClick!=null) {
			BtnClick(this,new EventArgs());
		}
	}
}
