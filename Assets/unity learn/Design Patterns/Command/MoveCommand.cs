using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using UnityEngine;
using Vector3 = UnityEngine.Vector3;

// Design Pattern
// Command Pattern 
// https://learn.unity.com/tutorial/command-pattern
public class MoveCommand : MonoBehaviour
{

    // Update is called once per frame
    void Update()
    {
	    if (Input.GetKeyDown(KeyCode.W))
	    {
		    MoveUp command = new MoveUp(transform);
		    command.Execute();
	    }
	    else if (Input.GetKeyDown(KeyCode.S))
	    {
		    MoveDown command = new MoveDown(transform);
		    command.Execute();
	    }
    }
}

class MoveUp {
	Transform moved;

	public MoveUp(Transform target)
	{
		moved = target;
	}

	public void Execute()
	{
		moved.Translate(Vector3.up);
	}
}

class MoveDown {
	Transform moved;

	public MoveDown(Transform target)
	{
		moved = target;
	}

	public void Execute()
	{
		moved.Translate(Vector3.down);
	}
}