using UnityEngine;
using System.Collections;

public class HeroPet : MonoBehaviour {

    public GameObject pet;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public void CreatePet()
    {
        GameObject newPet=Instantiate(pet, transform.position, Quaternion.identity)as GameObject;
        newPet.transform.parent = transform.parent;
        newPet.GetComponent<Team>().team = GetComponent<Team>().team;
        
    }
}
