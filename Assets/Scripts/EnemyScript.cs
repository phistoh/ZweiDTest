using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyScript : MonoBehaviour
{
	private WeaponScript[] weapons;
	
    // Start is called before the first frame update
    void Start()
    {
        
    }

	void Awake()
	{
		weapons = GetComponentsInChildren<WeaponScript>();
	}

    // Update is called once per frame
    void Update()
    {
		foreach (WeaponScript weapon in weapons)
		{
			if (weapon != null && weapon.CanAttack)
			{
				weapon.Attack(true);
			}
		}
    }
}