using UnityEngine;
using System.Collections;

public class BaseEnemy : NPC 
{

	protected float radius;



	public virtual void Move()
	{
		
	}

	public virtual void OnTriggerEnter()
	{
		
	}

	public virtual void DetectRange()
	{
		Collider[] itemsInRange = Physics.OverlapSphere (this.transform.position, radius);

		foreach (Collider col in itemsInRange) 
		{
			if(col.tag == Tags.FRIENDLY || col.tag == Tags.PLAYER)
			{
				this.transform.LookAt(col.transform);
			}
		}
	}

	public override void Awake()
	{
		base.Awake ();
		//_objectPool = GameObject.FindGameObjectWithTag (Tags.GAMECONTROLLER).GetComponent<ObjectPool> ();
	}

	public override void Update()
	{
		DetectRange ();
	}

	public override void Death()
	{
		base.Death();
	}



}
