using System;
using System.Collections.Generic;

public class MyStack
{
	private Stack<char> stack;
	public MyStack()
	{
		stack = new Stack<char>();
		
	}

	public int getCount()
	{
		return stack.Count;
	}

	public char getPeek()
	{
		return stack.Peek();
	}

	public void push(char item)
	{
		stack.Push(item);
	}

	public char pop()
	{
		return stack.Pop();
	}
}
