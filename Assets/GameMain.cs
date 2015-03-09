using UnityEngine;
using System.Collections;

public class GameMain : MonoBehaviour {

	// Use this for initialization
	void Start () {
		InvokeRepeating ("MakeFire", 0.2f, 1f);
	}

	void MakeFire(){
		GameObject ModalOK = Resources.Load ("Gun") as GameObject;
		GameObject child = Instantiate (ModalOK, ModalOK.transform.position, Quaternion.identity) as GameObject;
		child.name = "Gun";
		child.transform.SetParent(gameObject.transform);
		child.transform.position = new Vector2(Random.Range(-200,200), -400);
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetMouseButtonDown (0)) {  
			GameObject ModalOK = Resources.Load ("Fire") as GameObject;
			GameObject child = Instantiate (ModalOK, ModalOK.transform.position, Quaternion.identity) as GameObject;
			child.name = "Fire";
			child.transform.SetParent(gameObject.transform);
			Transform pistolPos = GameObject.Find("Pistol").transform; 
			child.transform.position = pistolPos.position;

		}
	}
}
