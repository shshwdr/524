using UnityEngine;
using System.Collections;

public class MouseClick : MonoBehaviour {
    public Texture2D cursorAttack;
    public Texture2D cursorMove;
    public CursorMode cursorMode;
    public Vector2 hotSpot;
    public GameObject player;
    public GameObject mouseClickParticle;
	// Use this for initialization
	void Start () {
        hotSpot=Vector2.zero;
	    
	}
	
	// Update is called once per frame
	void Update () {
        
        RaycastHit hitInfo;
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        if(Physics.Raycast(ray,out hitInfo))
        {
            Debug.Log(hitInfo.collider);
            if (hitInfo.collider.tag == Tags.Building||hitInfo.collider.tag==Tags.Minor)
            {

                Cursor.SetCursor(cursorAttack, hotSpot, cursorMode);
                if (Input.GetMouseButtonDown(1))
                { 
                    player.GetComponent<AstarPlayer>().SetTarget(hitInfo.collider.gameObject);
                }
            }
            else
            {
                Cursor.SetCursor(cursorMove, hotSpot, cursorMode);
                if (Input.GetMouseButtonDown(1))
                {
                  //  Instantiate(mouseClickParticle,hitInfo.point+transform.up*4,transform.rotation);
                    player.GetComponent<AstarPlayer>().SetTarget(hitInfo.point);
                }
            }
        }

	
	}
}
