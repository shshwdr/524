using UnityEngine;
using System.Collections;

public class MobaCamera : MonoBehaviour {

    public float moveEdge=10;
    public float moveSpeed = 5;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.mousePosition.x < moveEdge)
        {
            transform.position -= transform.right*Time.deltaTime*moveSpeed;
        }
        else if (Input.mousePosition.x > Screen.width-moveEdge)
        {
            transform.position += transform.right * Time.deltaTime * moveSpeed;
        }
        if (Input.mousePosition.y < moveEdge)
        {
            transform.position -= (transform.up + transform.forward) * Time.deltaTime * moveSpeed / 1.414f;
        }
        if (Input.mousePosition.y > Screen.height - moveEdge)
        {
            transform.position += (transform.up + transform.forward) * Time.deltaTime * moveSpeed / 1.414f;
        }
	}
}
