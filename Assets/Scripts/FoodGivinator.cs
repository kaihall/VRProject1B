using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FoodGivinator : MonoBehaviour
{
    public GameObject foodPrefab;
	public float cooldown = 2f;
	public FishMultiplierinator fishFlock;
	
	private float timeOfLastFeeding;
	
	// Start is called before the first frame update
    void Start()
    {
        timeOfLastFeeding = Time.time;
    }

    // Update is called once per frame
    void Update()
    {
        if (XRInputManager.IsButtonDown() && Time.time - timeOfLastFeeding >= cooldown) {
			Vector3 destMod = Vector3.zero;
			
			destMod.y = Mathf.Sin(Mathf.Deg2Rad*transform.rotation.x) * Mathf.Cos(Mathf.Deg2Rad*transform.rotation.y);
			destMod.x = Mathf.Sin(Mathf.Deg2Rad*transform.rotation.x) * Mathf.Sin(Mathf.Deg2Rad*transform.rotation.y);
			destMod.z = Mathf.Cos(Mathf.Deg2Rad*transform.rotation.x);
			
			GameObject food = Instantiate(foodPrefab, transform.position + (0.5f*destMod), Quaternion.identity);
			food.GetComponent<Sendoffinator>().SendOff(transform.position + destMod);
			
			fishFlock.foodGiven = true;
			
			timeOfLastFeeding = Time.time;
		}
    }
}
