using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AG_MovementTest : MonoBehaviour
{
	 float timer = 1;
	 float timer2 = .5f;
	void Update () {

		if (Input.GetAxis("Horizontal") != 0 )
		{
			if (timer<= 0)
			{
				Debug.Log("Tek Hareket");
				timer = 1;

			}
			if (timer2 <= 0)
			{
				Debug.Log("Hızlı Hareket");
			}
			
		}
		else
		{
			timer = 1;
			timer2 = 1;
		}

		if (timer >= 0)
			timer -= Time.deltaTime;
		

		if (timer2 >= 0)
			timer2 -= Time.deltaTime;
		
	}
}
