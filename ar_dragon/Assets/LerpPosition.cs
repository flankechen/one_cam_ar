using UnityEngine;
using System.Collections;

public class LerpPosition : MonoBehaviour {

	public MeshRenderer meshrender;
	public GameObject dragonObj;

	// Use this for initialization
	void Start () {
		dragonObj.gameObject.SetActive (false);
	}
	
	// Update is called once per frame
	void Update () {
		if (meshrender.enabled) {
//			Debug.Log("1");
			if(!dragonObj.activeInHierarchy)
				dragonObj.gameObject.SetActive (true);
			dragonObj.transform.position = Vector3.Lerp(dragonObj.transform.position,meshrender.transform.position,Time.deltaTime*50f);
			dragonObj.transform.rotation = Quaternion.Slerp(dragonObj.transform.rotation,meshrender.transform.rotation,Time.deltaTime*50f);
		}
		else{
			if(dragonObj.activeInHierarchy)
				dragonObj.gameObject.SetActive (false);
		}
	}
}
