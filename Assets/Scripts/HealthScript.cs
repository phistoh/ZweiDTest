using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthScript : MonoBehaviour
{
	public int hp = 1;
	public bool isEnemy = true;
	
	SpriteRenderer sprite;
	
	public void Damage(int damageCount)
	{
			hp -= damageCount;
			if (hp <= 0)
			{
				SpecialEffectsHelper.Instance.Explosion(transform.position);
				SoundEffectsHelper.Instance.MakeExplosionSound();
				Destroy(gameObject);
			}
			if (isEnemy == false && hp == 2)
			{
				sprite.color = new Color (0.94f,0.53f,0.18f, 1); 
			}
			if (isEnemy == false && hp == 1)
			{
				sprite.color = new Color (0.9f, 0.17f, 0.01f, 1); 
			}
	}
	
	void OnTriggerEnter2D(Collider2D otherCollider)
	{
		ShotScript shot = otherCollider.gameObject.GetComponent<ShotScript>();
		if(shot != null)
		{
			if(shot.isEnemyShot != isEnemy)
			{
				Damage(shot.damage);
				Destroy(shot.gameObject);
			}
		}
	}
	
	
    // Start is called before the first frame update
    void Start()
    {
        sprite = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
