using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class OnClickOnSettings: MonoBehaviour
{
	public Button yourButton;
	public Button helpButton;
	public Button SoundButton;
	public Button MuteButton;
	public static bool isSound;

	void Start()
	{
		isSound = true;
		Button btn = yourButton.GetComponent<Button>();
		btn.onClick.AddListener(TaskOnClick);
	
		SoundButton.gameObject.SetActive (false);
		helpButton.gameObject.SetActive (false);
		MuteButton.gameObject.SetActive (false);

	}

	void TaskOnClick()
	{

		if (!helpButton.gameObject.activeSelf) {
			if (isSound) {
				MuteButton.gameObject.SetActive (false);
				SoundButton.gameObject.SetActive (true);
			} else {
				SoundButton.gameObject.SetActive (false);
				MuteButton.gameObject.SetActive (true);
			}
		}

		if (helpButton.gameObject.activeSelf) {
			helpButton.gameObject.SetActive (false);
			SoundButton.gameObject.SetActive (false);
			MuteButton.gameObject.SetActive (false);
		} else {
			helpButton.gameObject.SetActive (true);
		}


	}
}