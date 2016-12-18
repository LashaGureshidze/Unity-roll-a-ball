using UnityEngine;
using System.Collections;

public class ZoneScript : MonoBehaviour {

	//public float density = 1f; //zonis simkvrive

	public Vector2 buoyancy = new Vector2(0f, 9.81f);

	public float top;
	public float height;

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
	
	}


	public void OnTriggerStay2D(Collider2D collider) {
		/*if (collider.gameObject.tag == "player") {
			//Bounds bounds = collider.GetComponent<SpriteRenderer>().bounds;
			//Debug.Log ("sprite Renderer size = " + bounds.size);
			float sunkArea = getSunkArea(top, collider.transform.position.y, (collider.GetComponent<CircleCollider2D>().radius * collider.transform.localScale.y));
			Debug.Log("up force=" + 9.80665f * density * sunkArea);
			collider.GetComponent<Rigidbody2D>().AddForce(new Vector2(0, 9.80665f * density * sunkArea - 0.5f));
		}*/
		if (collider.gameObject.tag == "player") {
			float forceFactor =((top - collider.transform.position.y) / height);
			//Debug.Log("forcefactor = " + forceFactor);
			if (forceFactor > 0f)
				collider.GetComponent<Rigidbody2D>().AddForce(buoyancy * (forceFactor + 1));

		}
	}

	/*

	private float getSunkArea(float waterY, float circleY, float circleRadius) {
		Debug.Log ("Zone watery= " + waterY);
		Debug.Log ("Zone circley= " + circleY);
		Debug.Log ("Zone radius=" + circleRadius);
		float angle = getAngle (waterY, circleY, circleRadius);
		return getSectorArea (circleRadius, angle) - getTriangleArea (circleRadius, angle);
	}

	private float getAngle(float waterY, float circleY, float circleRadius) {
		//double dist = Math.Abs (waterX - circleX);
		float dist = circleY - waterY ;
		Debug.Log ("Zone dist=" + dist);
		float cos = Mathf.Min (Mathf.Max (dist / circleRadius, -1), 1);
		Debug.Log ("Zone cos = " + cos);
		float angle = Mathf.Acos (cos) * Mathf.Rad2Deg* 2;
	    Debug.Log ("Zone angle=" + angle);
		return angle;
	}

	private float getSectorArea(float radius, float angle) {
		float sectorArea = (Mathf.PI * radius * radius * angle) / 360;
		Debug.Log ("SectorArea " + sectorArea);
		return sectorArea;
	}

	private float getTriangleArea(float radius, float angle) {
		float triangleArea = (1 / 2) * radius * radius * Mathf.Sin (angle);
		Debug.Log ("triangleArea " + triangleArea);
		return triangleArea;
	}

*/
}
