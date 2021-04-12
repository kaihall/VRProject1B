using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sendoffinator : MonoBehaviour
{
	private Vector3 destination;
	
    // Start is called before the first frame update
    void Start()
    {
        if (destination == null) 
			destination = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector3.Lerp(transform.position, destination, 0.5f * Time.deltaTime);
    }
	
	public void SendOff(Vector3 dest) {
		destination = dest;
	}
}
