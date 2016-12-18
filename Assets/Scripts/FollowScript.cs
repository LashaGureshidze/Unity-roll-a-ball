using UnityEngine;
using System.Collections;

public class FollowScript : MonoBehaviour {

	public Transform target;

	public float bottom;

	public int level;


	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (target == null) return;
		if (target.position.y < bottom) {

			if (level > 0) {
				SoundEffectsHelper.Instance.MakeYellSound();
				Destroy(target.gameObject);
				StartCoroutine("Wait");
			}

			return;
		}
		transform.position = new Vector3 (target.position.x, target.position.y, transform.position.z);
	}

	IEnumerator Wait()
	{
		yield return new WaitForSeconds(1);
		
		Application.LoadLevel("Level" + level);
	}
}
