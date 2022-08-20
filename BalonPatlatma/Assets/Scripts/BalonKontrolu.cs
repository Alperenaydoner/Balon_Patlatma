using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BalonKontrolu : MonoBehaviour {
	public GameObject patlama;
	OyunKontrolcu oyunKontrolScripti;

	void Start(){
		oyunKontrolScripti = GameObject.Find ("_Scripts").GetComponent<OyunKontrolcu> ();
	}

	void OnMouseDown(){
		GameObject go = Instantiate (patlama, transform.position,transform.rotation)as GameObject;
		Destroy (this.gameObject);
		Destroy (go, 0.333f);
		oyunKontrolScripti.BalonEkle ();
	}
}
