using UnityEngine.Audio;
using UnityEngine;
using UnityEngine.UI;

[System.Serializable]
public class Sound {

	public string name;
	public  Slider volumein;
	public AudioClip clip;

	[Range(0f, 1f)]
	public float volume = .75f;

//	public float temp = volumein.value;
//	public float Volume
//	{
//		get { return volumein.value; }
//		set { volume = value; }
//	}

	
	[Range(0f, 1f)]
	public float volumeVariance = .1f;

	[Range(.1f, 3f)]
	public float pitch = 1f;
	[Range(0f, 1f)]
	public float pitchVariance = .1f;

	public bool loop = false;
	
	
	public AudioMixerGroup mixerGroup;

	[HideInInspector]
	public AudioSource source;

}
