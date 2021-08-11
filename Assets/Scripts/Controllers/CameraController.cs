using UnityEngine;

/* Makes the camera follow the player */

public class CameraController : MonoBehaviour {

	public Transform target;

	public Vector3 offset;
    public float zoomspeed = 4f;
    public float minZoom = 5f;
    public float maxZoom = 15f;
    public float pitch = 2f;
    //public float smoothSpeed = 2f;

    public float currentZoom = 10f;

 //   public float yawSpeed = 70;
	//public float zoomSensitivity = .7f;
    
	//float dst;

	//float zoomSmoothV;
	//float targetZoom;

	//void Start() {
	//	//dst = offset.magnitude;
	//	transform.LookAt (target);
	//	targetZoom = currentZoom;
	//}

	void Update ()
	{
		currentZoom -= Input.GetAxisRaw("Mouse ScrollWheel") * zoomspeed;
        currentZoom = Mathf.Clamp(currentZoom, minZoom, maxZoom);

		//if (scroll != 0f)
		//{
		//	targetZoom = Mathf.Clamp(targetZoom - scroll, minZoom, maxZoom);
		//}
		//currentZoom = Mathf.SmoothDamp (currentZoom, targetZoom, ref zoomSmoothV, .15f);
	}

	void LateUpdate () {
        transform.position = target.position - offset * currentZoom; /*transform.forward * dst * currentZoom;*/
        transform.LookAt(target.position + Vector3.up * pitch);

		//float yawInput = Input.GetAxisRaw ("Horizontal");
		//transform.RotateAround (target.position, Vector3.up, -yawInput * yawSpeed * Time.deltaTime);
	}

}
