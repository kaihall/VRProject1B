using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FoodDestroyinator : MonoBehaviour
{
    private int lifetime = 1;
	private float birthTime;
	
	// Start is called before the first frame update
    void Start()
    {
		birthTime = Time.time;
    }

    // Update is called once per frame
    void Update()
    {
        if(Time.time - birthTime > lifetime) {
			Destroy(gameObject);
		}
    }
}
