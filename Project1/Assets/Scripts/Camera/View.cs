using UnityEngine;
using System.Collections;

public class View : MonoBehaviour {

    public float sensitivity = 5f;
    public float smoothing = 2f;
    public float minYLook = -90f;
    public float maxYLook = 90f;
    public float minXLook = -360f;
    public float maxXLook = 360f;

    private Vector2 mouseLook;
    private Vector2 smoothV;

    // Use this for initialization
    void Start () {
        Cursor.lockState = CursorLockMode.Locked;
	}
	
	// Update is called once per frame
	void Update () {
        //rotation view
        Vector2 mouseDir = new Vector2(Input.GetAxisRaw("Mouse X"), Input.GetAxisRaw("Mouse Y"));

        mouseDir = Vector2.Scale(mouseDir, new Vector2(sensitivity * smoothing, sensitivity * smoothing));
        smoothV.x = Mathf.Lerp(smoothV.x, mouseDir.x, 1f / smoothing);
        smoothV.y = Mathf.Lerp(smoothV.y, mouseDir.y, 1f / smoothing);
        mouseLook += smoothV;

        mouseLook.y = Mathf.Clamp(mouseLook.y, minYLook, maxYLook);
        mouseLook.x = Mathf.Clamp(mouseLook.x, minXLook, maxXLook);

        transform.localRotation = Quaternion.AngleAxis(-mouseLook.y, Vector3.right);
        transform.parent.gameObject.transform.localRotation = Quaternion.AngleAxis(mouseLook.x, Vector3.up);

        if (Input.GetKeyDown("escape"))
            Cursor.lockState = CursorLockMode.None;
    }
}
