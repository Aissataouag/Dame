using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Plateau : MonoBehaviour {

	public int taille = 8;
	public Dictionary<int, Case> cases = new Dictionary<int, Case> ();
	public GameObject casePrefab; 
	public GameObject piecePrefab;
	public GameObject plateauPrefab;
	// Use this for initialization
	void Start () {
		int id = 0;

		for(int i = 0; i <= taille ; i++){
			
			for(int j = 0; j <= taille ;  j++){
				
				GameObject caseObjet = (GameObject)Instantiate (casePrefab);
				Case case  = caseObjet.AddComponent<Case> (); 
				id++;
	       }

		}
	}
	// Update is called once per frame
	void Update () {
		
	}
}
