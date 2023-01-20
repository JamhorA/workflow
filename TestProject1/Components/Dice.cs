using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject1.Components
{
	internal class Dice
	{
		public int throwDice()
		{
			Random random = new Random();
			int randomValue = random.Next(1,6);
			return randomValue; 
		}
	}
}
