using UnityEngine;
using System.Collections;

public class View : MonoBehaviour {
	public BtnViewPresenter AddExpBtnView;
	public BtnViewPresenter TakeDamageBtnView;
	public LabViewPresenter HpLabView;
	public LabViewPresenter ExpLabView;
	public LabViewPresenter LevelLabView;
	public void show(){
		AddExpBtnView.gameObject.SetActive (true);
		TakeDamageBtnView.gameObject.SetActive (true);
		HpLabView.gameObject.SetActive (true);
		ExpLabView.gameObject.SetActive (true);
		LevelLabView.gameObject.SetActive (true);

	}
	public void hide(){
		AddExpBtnView.gameObject.SetActive (false);
		TakeDamageBtnView.gameObject.SetActive (false);
		HpLabView.gameObject.SetActive (false);
		ExpLabView.gameObject.SetActive (false);
		LevelLabView.gameObject.SetActive (false);
	}
}
