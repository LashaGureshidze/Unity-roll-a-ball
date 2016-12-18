using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class MenuScript : MonoBehaviour {

	private bool music = true;
	private bool sound = true;

	private Text text;

	// Use this for initialization
	void Start () {
		text = GetComponent<Text> ();
	}


	public void onStartGame() {
		SoundEffectsHelper.Instance.MakeButtonSound();

		Application.LoadLevel ("ChooseLevel");
	}

	public void onExit() {
		SoundEffectsHelper.Instance.MakeButtonSound();

		Application.Quit ();
	}

	public void onMusic() {
		SoundEffectsHelper.Instance.MakeButtonSound();
		//TODO
		music = ! music;

		if (music) {
			text.text = "Music : ON";
		} else {
			text.text = "Music : OFF";
		}
	}

	public void onSound() {
		SoundEffectsHelper.Instance.MakeButtonSound();


		sound = !sound;

		SoundEffectsHelper.Instance.enabled = sound;

		if (sound) {
			text.text = "Sounds : ON";
		} else {
			text.text = "Sounds : OFF";
		}

	}



}
