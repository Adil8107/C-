class Prac1aa
{
	public static void Main(string[] args)
	{
		System.Console.Write("Enter the first integer:");
		int num1=int.Parse(Console.ReadLine());

		System.Console.Write("Enter the second integer:");
		int num2=int.Parse(Console.ReadLine());

		System.Console.Write("Enter the third integer:");
		int num3=int.Parse(Console.ReadLine());

		System.Console.Write("Enter the fourth integer:");
		int num4=int.Parse(Console.ReadLine());

		int product= num1*num2*num3*num4;
		Console.WriteLine("The product of four integer is:"+product);
                Console.ReadLine();
	}
}