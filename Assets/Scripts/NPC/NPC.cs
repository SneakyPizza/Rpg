using UnityEngine;
using System.Collections;

public class NPC : MonoBehaviour 
{
	protected float _health;
	protected float _mana;
	protected float _energy;

	protected ObjectPool _objectPool;
	
	public virtual void Awake()
	{
		_objectPool = GameObject.FindGameObjectWithTag(Tags.GAMECONTROLLER).GetComponent<ObjectPool>();
	}

	public virtual void Death()
	{
		_objectPool.PoolObject (this.gameObject);
	}

	public virtual void Start()
	{
		
	}

	public virtual void Update()
	{

	}

}
