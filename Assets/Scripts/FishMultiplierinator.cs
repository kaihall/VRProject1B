using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FishMultiplierinator : MonoBehaviour
{
	internal bool foodGiven = false;
	
	public float deathRate = 0.02f;
	public float birthRate = 0.02f;
	public float checkRate = 3f;
	public NVBoids turtleFlock;
	
	private float timeOfLastCheck;
	private NVBoids flock;
	
    // Start is called before the first frame update
    void Start()
    {
        timeOfLastCheck = Time.time;
		flock = GetComponent<NVBoids>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.time - timeOfLastCheck >= 3) {
			timeOfLastCheck = Time.time;
			
			float trueBR = birthRate;
			if (foodGiven) {
				foodGiven = false;
				trueBR += 0.05f;
			}
			
			flock.birdsNum = (int)Mathf.Round(flock.birdsNum * (1 + trueBR) * (1 - deathRate));
			flock.birdsNum = flock.birdsNum - (turtleFlock.birdsNum * 10);
		}
    }
}
