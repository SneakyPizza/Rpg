using UnityEngine;
using System.Collections;

public class SmallEnemy : BaseEnemy 
{
	public override void DetectRange()
	{
		base.DetectRange ();
		radius = 2;
	}

	public override void Awake ()
	{
		base.Awake ();
	}

	public override void Update()
	{
		base.Update ();

	}

	public override void Move()
	{
		base.Move ();
	}

	public override void Death()
	{
		base.Death ();
	}
	
}
