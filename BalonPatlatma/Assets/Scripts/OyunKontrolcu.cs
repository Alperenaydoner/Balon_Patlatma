using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class OyunKontrolcu : MonoBehaviour {
	public UnityEngine.UI.Text zamanText, balonText;
	public GameObject patlama;
	public float zamanSayaci = 10;
	
	int patlayanBalon=0;
	// Use this for initialization
	void Start () {
		balonText.text = "Balon : " + patlayanBalon;
	}
	
	// Update is called once per frame
	public void Update () {
		if (zamanSayaci > 0)
		{
			zamanSayaci -= Time.deltaTime;
			zamanText.text = "Süre : " + (int)zamanSayaci;
		}

		else
		{
			GameObject[] go = GameObject.FindGameObjectsWithTag("balon");
			for (int i = 0; i < go.Length; i++)
			{
				Instantiate(patlama, go[i].transform.position, go[i].transform.rotation);
				Destroy(go[i]);
			}
			
				SceneManager.LoadScene("son_sahne");
			
		}
	}
	
	public void BalonEkle(){
		patlayanBalon += 1;
		balonText.text = "Balon : " + patlayanBalon;
	}
}
