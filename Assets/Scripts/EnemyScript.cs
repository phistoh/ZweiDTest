using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyScript : MonoBehaviour
{
	private bool hasSpawn;
	private MoveScript moveScript;
	private WeaponScript[] weapons;
	private Collider2D colliderComponent;
	private SpriteRenderer rendererComponent;
	
    // Start is called before the first frame update
    void Start()
    {
        hasSpawn = false;
		colliderComponent.enabled = false;
		moveScript.enabled = false;
		foreach (WeaponScript weapon in weapons)
		{
			weapon.enabled = false;
		}
    }

	void Awake()
	{
		weapons = GetComponentsInChildren<WeaponScript>();
		moveScript = GetComponent<MoveScript>();
		colliderComponent = GetComponent<Collider2D>();
		rendererComponent = GetComponent<SpriteRenderer>();
		
	}

    // Update is called once per frame
    void Update()
    {
		if (hasSpawn == false)
		{
			if (rendererComponent.IsVisibleFrom(Camera.main))
			{
				Spawn();
			}
		}
		else
		{
			foreach (WeaponScript weapon in weapons)
			{
				if (weapon != null && weapon.enabled && weapon.CanAttack)
				{
					weapon.Attack(true);
				}
			}
			
			if (rendererComponent.IsVisibleFrom(Camera.main) == false)
			{
				Destroy(gameObject);
			}
		}
    }
	
	private void Spawn()
	{
		hasSpawn = true;
		
		colliderComponent.enabled = true;
		moveScript.enabled = true;
		foreach (WeaponScript weapon in weapons)
		{
			weapon.enabled = true;
		}
	}
}
