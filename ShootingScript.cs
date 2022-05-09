using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootingScript : MonoBehaviour {

	public GameObject Bullet;
	public float bulletSpeed;
	public Transform ShootingPoint;

	Vector2 direction;
	
	// Update is called once per frame
	void Update () 
	{
		pointToMouse();

		if(Input.GetMouseButtonDown(0))
		{
			shoot();
		}	

	}

	void pointToMouse()
    {
		Vector2 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
		direction = mousePos - (Vector2)transform.position;

		transform.right = direction;
	}

	void shoot()
	{
		GameObject bulletins = Instantiate(Bullet,ShootingPoint.position,ShootingPoint.rotation);
		bulletins.GetComponent<Rigidbody2D>().AddForce(bulletins.transform.right  * bulletSpeed);

		Destroy(bulletins,5);
	}
}
