namespace TestProject1.Components
{
    internal class Calculator
    {
        public Calculator()
        {
        }

		internal int Add()
		{
			return 0;
		}

		internal int Add(int number1, int number2)
		{
			int result = number1 + number2;
			return result;
		}

		internal int Calc(int number, int secondNumber, string calcType)
		{
			int result = 0;
			if (calcType == "+")
			
				result = number + secondNumber;
			
			if(calcType == "-")
			
				result = number - secondNumber;
			
			if (calcType == "/")
			
				result = number / secondNumber;
			
			if (calcType == "*")

				result = number * secondNumber;
			
			return result;
		}

		internal object Minus(int number, int secondNumber)
		{
			int result = number - secondNumber;
			return result;
		}
	}
}