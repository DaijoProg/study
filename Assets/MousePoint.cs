using UnityEngine;
using System.Collections;

public class MousePoint : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetMouseButton (0)) {
			Vector2 point = Camera.main.ScreenToWorldPoint (Input.mousePosition);
			Collider2D hitObject = Physics2D.OverlapPoint (point); 
//			if (hitObject) {

				gameObject.transform.position = new Vector3(point.x, point.y,0 );
//				Deb ug.Log("point x="+point.x+"  pointy y="+point.y );

//			}
		}

	}
}
