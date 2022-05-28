using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System

public class KissPrensibleExample
{
    bool item1=false;
    bool item2=false;
    bool item3=true;
    bool item4= true;
	void KissBadCode()
    {
		if (item1)
		{
			if (item2)
			{
				if (item3)
				{
					if (item4)
						Console.WriteLine("God Mode");
					else
						Console.WriteLine("Half God Mode");
				}
				else
				{
					if (item4 == true)
						Console.WriteLine("Half God Mode");
					else
						Console.WriteLine("Quarter God Mode");
				}
			}
			else
				Console.WriteLine("Regular Mode");
		}
	}
	void KissGreatCode()
    {
		if (item1 && item2 && item3 && item4)
			Console.WriteLine("God Mode");

		else if (item1 && item2 && item3 && item4 == false)
			Console.WriteLine("Half God Mode");
		else if (item1 && item2 && item3 == false && item4)
			Console.WriteLine("Half God Mode");
		else if (item1 && item2 && item3 == false && item4 == false)
			Console.WriteLine("Quarter God Mode");
		else
			Console.WriteLine("Regular Mode");
		//I think it is better then anothers.
		

	}
	void AnotherGreatCode()
    {
		int itemCount = 0;
		indexer[] itemsHelds =[item1, item2, item3, item4];
		
		foreach (singleItem in itemsHelds)
			if(singleItem == true)
				itemCount++;

        switch (itemCount)
        {	
			case 4:
				Console.WriteLine("God Mode");
				break;
			case 3:
				Console.WriteLine("Half God Mode");
				break;
			case 2:
				Console.WriteLine("Quarter God Mode");
				break;
			case 1:
				Console.WriteLine("Regular Mode");
				break;
			default:
                break;
        }
    }	


}
