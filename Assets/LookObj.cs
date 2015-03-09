using UnityEngine;
using System.Collections;

public class LookObj : MonoBehaviour {
	float speed = 10; // 実際に動かしてみて速度調整してください
	public GameObject obj;
	public static Quaternion rotation ;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		LookAt2D(obj);
		//		Move(obj);
	}
	
	void LookAt2D(GameObject target)
	{
		// 指定オブジェクトと回転さすオブジェクトの位置の差分(ベクトル)
		Vector3 pos = target.transform.position - transform.position;
		// ベクトルのX,Yを使い回転角を求める
		float angle = Mathf.Atan2(pos.y, pos.x) * Mathf.Rad2Deg;
		rotation = new Quaternion();
		// 回転角は右方向が0度なので-90しています
		rotation.eulerAngles = new Vector3(0, 0, angle - 90);
		// 回転
		transform.rotation = rotation;

	}


}
