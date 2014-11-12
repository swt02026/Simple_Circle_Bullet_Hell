using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class ClickTimesCount : MonoBehaviour {
	int times= 0;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	public void TimesChange(){
		times++;
		this.guiText.text = times.ToString ();
	}
}
