using UnityEngine;
using System.Collections;

public class ChooseLevelScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void onMainMenu() {
		SoundEffectsHelper.Instance.MakeButtonSound();

		Application.LoadLevel ("Menu");
	}

	public void onLevel(int level) {
		//TODO
		SoundEffectsHelper.Instance.MakeButtonSound();

		Application.LoadLevel ("Level" + level);
	}
}
