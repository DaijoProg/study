using UnityEngine;
using System.Collections;

public class Fire : MonoBehaviour {
 float power = 30000;
	GameObject VectorParent;
	// Use this for initialization
	void Start () {
//commit Test
		gameObject.transform.rigidbody2D.AddForce(Vector2.up * Random.Range(30000,40000)); // 正規化したベクトル * スピード

	}
	public GameObject shellObject;
	// Update is called once per frame

	public void SetAngle(){

	}

	void Update () {
		if (Input.GetMouseButton(0)) {    
//
//			VectorParent = GameObject.Find ("Pistol");
//			Transform parentForm = VectorParent.transform; 
//			Transform thisForm = gameObject.transform;
//			var ray = Camera.main.ScreenPointToRay(Input.mousePosition);
//			var dir = ray.direction.normalized;
//
//			Vector2 point = Camera.main.ScreenToWorldPoint (Input.mousePosition);
//			Vector3 vec = Input.mousePosition;
//			vec.z = 10f;
////			vec = camera.ScreenToWorldPoint(vec);
//			Vector3 nVec = Vector3.Normalize(vec - gameObject.transform.position);
//			gameObject.transform.rigidbody2D.AddForce(nVec * 10000); // 正規化したベクトル * スピード
//
//
//			Debug.Log("look ="+nVec );


		}
	
	}

	void OnTriggerEnter2D (Collider2D c)
	{
		particleSystem.Play();
		// 弾の削除
//		Destroy(c.gameObject);
		
		// 爆発する

		// プレイヤーを削除
		Destroy (gameObject);
	}


//	void FixedUpdate()
//	{
//		//左右キーの入力
//		float h = Input.GetAxis("Horizontal");
//		//上下キーの入力
//		float v = Input.GetAxis("Vertical");
//		
//		//左右キーの入力にあわせて、横方向の力を加える（歩く）
//		rigidbody2D.AddForce(Vector2.right * h * 30f);
//		
//		//もし、上キーの入力だったら（下キーは無視する）
//		if(v > 0)
//		{
//			//上方向の力を加える（飛ぶ）
//			rigidbody2D.AddForce(Vector2.up * v * 50f);
//		}
//	}
}
