using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour {

	public Button start;

	// Use this for initialization
	void Start () {
		Button btn = start.GetComponent<Button>();
		btn.onClick.AddListener(TaskOnClick);
	}
	
	// Update is called once per frame
	public void TaskOnClick(){

		SceneManager.LoadScene ("newmap");
	}
}
