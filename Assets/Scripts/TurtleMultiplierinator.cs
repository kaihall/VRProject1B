using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurtleMultiplierinator : MonoBehaviour
{
    public NVBoids fishFlock;
	
	private NVBoids flock;
	
	// Start is called before the first frame update
    void Start()
    {
        flock = GetComponent<NVBoids>();
    }

    // Update is called once per frame
    void Update()
    {
        flock.birdsNum = (int)Mathf.Round(fishFlock.birdsNum/100);
    }
}
