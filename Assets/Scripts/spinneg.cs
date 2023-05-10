using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spinneg : MonoBehaviour
{
	void Update()
	{
		transform.Rotate(0f, 1f, 0f, Space.Self);//Rotate(x, y, z) + = add one per update
	}
}