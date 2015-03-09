using UnityEngine;
using System.Collections;

public class PlayerFire : MonoBehaviour {

	// Use this for initialization
	void Start () {

		Transform mousePos = GameObject.Find ("Mouse").transform;
		iTween.MoveTo(gameObject, iTween.Hash("x", mousePos.localPosition.x,"y", mousePos.localPosition.y,"time", 0.5f, "islocal", true));
		Invoke ("DestroyObj", 0.5f);
//		iTween.ValueTo(gameObject, iTween.Hash("from", 0, "to", 200, "time", 0.5f, "onupdate", "UpdateHandler"));
	
	}

	void DestroyObj(){
		Destroy (gameObject);
	}

	private void UpdateHandler(float value)
	{
		print(value);
	}

	// Update is called once per frame
	void Update () {
	
	}
}
