using UnityEngine;
using System.Collections;

public class ScriptRay : MonoBehaviour {
	void Start () {
	Screen.lockCursor = true;
	}
	// Update is called once per frame
	void Update () {
		transform.eulerAngles = new Vector3(0,Camera.main.transform.eulerAngles.y,0);
		RaycastHit hit;
		if(Input.GetButtonDown("Fire1")){
			Ray ray = Camera.main.ScreenPointToRay(new Vector3(Screen.width/2,Screen.height/2,0));
			if(Physics.Raycast(ray,out hit,10000f)){
				Debug.DrawLine(ray.origin,hit.point);
				if(hit.collider.gameObject.name=="Target" && hit.distance >= 4){
					Destroy(hit.collider.gameObject);
				}
			}
		}
	}
}
