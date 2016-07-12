using UnityEngine;
using System.Collections;

public class AnimationManage : MonoBehaviour {

	public Animator anim;
	public MeshRenderer meshrender;
	private bool isChange;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (meshrender.enabled) {
			if (!isChange) {
				isChange = true;
				anim.SetBool("go",true);
			}
		} 
		else {
			isChange = false;
			anim.SetBool("go",false);
		}
	}
}
