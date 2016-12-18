using UnityEngine;
using System.Collections;

public class SoundEffectsHelper : MonoBehaviour
{
	
	/// Singleton
	public static SoundEffectsHelper Instance;

	public AudioClip jumpSound;
	public AudioClip yellSound;
	public AudioClip pointSound;
	public AudioClip buttonSound;


	public bool soundEnabled = true;
	
	void Awake()
	{
		// Register the singleton
		if (Instance != null && Instance != this) {
			Debug.Log("reinstanciete SoundEffectHalper");

			Destroy (this.gameObject);

			return;
		} else {
			Instance = this;
		}

		//maintain all in scenes
		DontDestroyOnLoad(gameObject);
	}

	public void MakeJumpSound() {
		if (soundEnabled) MakeSound (jumpSound);
	}
	
	public void MakeYellSound()
	{
		if (soundEnabled) MakeSound(yellSound);
	}
	
	public void MakePointSound()
	{
		if (soundEnabled) MakeSound(pointSound);
	}
	
	public void MakeButtonSound()
	{
		MakeSound(buttonSound);
	}
	
	private void MakeSound(AudioClip originalClip)
	{
		AudioSource.PlayClipAtPoint(originalClip, transform.position);
	}
}