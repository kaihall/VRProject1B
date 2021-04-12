using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class FlockCountinator : MonoBehaviour
{
    public NVBoids flock;
	public string flockName;
	
	private TextMeshPro counter;
	
	// Start is called before the first frame update
    void Start()
    {
		counter = GetComponent<TextMeshPro>();
    }

    // Update is called once per frame
    void Update()
    {
        counter.text = flockName + ": " + flock.birdsNum;
    }
}
