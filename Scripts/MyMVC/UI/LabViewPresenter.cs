using UnityEngine;
using System.Collections;

public class LabViewPresenter : MonoBehaviour {
	public UILabel lab;
	public string Text{
		get{ return lab.text;}
		set{ lab.text = value;}
	}
	public UnityEngine.Color TextColor{
		get{ return lab.color;}
		set{ lab.color = value;}
	}
}
