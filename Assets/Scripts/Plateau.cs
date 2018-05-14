using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Plateau : MonoBehaviour {

	public int taille = 8;
	public Dictionary<int, Case> casees = new Dictionary<int, Case> ();
	public GameObject casePrefab; 
	public GameObject piecePrefab;
	public GameObject plateauPrefab;
    private object caseObjectRenderer;

    // Use this for initialization
    void Start () {
		int id = 1;

		for(int i = 1; i <= taille ; i++){
			
			for(int j = 1; j <= taille ;  j++){
				
				GameObject caseObject = (GameObject)Instantiate (casePrefab);
				Case casee  = caseObject.AddComponent<Case> ();
                caseObject.transform.parent = transform;
                caseObject.name = "case " + id;
                casee.coordonnees = new Vector2(i, j);
                caseObject.transform.position = new Vector3(i, 0, j);

                if (i % 2 == 0 && j % 2 == 1 || i % 2 == 1 && j % 2 == 0)
                {
                    casee.couleur = new Color(0, 0, 0);
                }
                else
                {
                    casee.couleur = new Color(1, 1, 1);
                }
                MeshRenderer caseObjectRenderer = caseObject.GetComponent<MeshRenderer>();
                Material caseObjectMaterial = new Material(Shader.Find("Standard"));
                caseObjectMaterial.color = casee.couleur;
                caseObjectRenderer.material = caseObjectMaterial;
                id++; 
	       }
		}
	}
	// Update is called once per frame
	void Update () {
		
	}
}
