using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System;
public class prefab : MonoBehaviour {
	public GameObject prefabbullet;
	float FanAngle;
	public int density = 8;
	bool canshot=true;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	public void setShotDensity(Text text){
		density=Convert.ToInt32 (text.text);
	}
	public void setAngle(Slider slider){
		this.FanAngle = slider.value;
	}
	public void putBullet_fan(){
		float angle =FanAngle / density,range = FanAngle/2, CurAngle = -range+angle/2;
		
		for (int i = 0; i < density; i++) {
			GameObject I = (GameObject)Instantiate (prefabbullet
			                                        , transform.position + new Vector3 (0,0, 1), transform.rotation);
			I.rigidbody2D.velocity = Quaternion.Euler (0, 0, (float)CurAngle) * transform.up;
			CurAngle += angle;
			Destroy(I,5);
		}
	}
	public void putBullet_circle(){
		this.FanAngle = 360;
		putBullet_fan ();
		/*double angle =360 / density, CurAngle = 0.0;

		for (int i = 0; i < density; i++) {
			GameObject I = (GameObject)Instantiate (prefabbullet
			                                        , transform.position + new Vector3 (0,0, 1), transform.rotation);
			I.rigidbody2D.velocity = Quaternion.Euler (0, 0, (float)CurAngle) * (new Vector2 (0.5f,0));
			CurAngle += angle;
			Destroy(I,5);
		}*/
	}
}
