using UnityEngine;
using System.Collections;

public class NoteScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
        
	}

    //move the object downwards
    public float movementSpeed = 10;

    void Update()
    {
        transform.Translate(Vector3.down * movementSpeed * Time.deltaTime);
    }
}
