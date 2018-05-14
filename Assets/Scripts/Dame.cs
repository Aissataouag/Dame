using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dame : MonoBehaviour {
	public Plateau plateau;

	void Start () {
		GameObject plateauObjet = new GameObject ("Plateau");
		plateauObjet.transform.parent = transform;
		plateau = plateauObjet.AddComponent<Plateau> ();
		plateau.casePrefab = (GameObject)Resources.Load ("Prefabs/Case");
		plateau.piecePrefab = (GameObject)Resources.Load ("Prefabs/piece");
	//	plateau.plateauPrefab = (GameObject)Resources.Load ("Prefabs/plateau");


	}

}
