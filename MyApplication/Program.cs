// **************************************************
// **************************************************
// **************************************************
// https://open.kattis.com/problems
// https://open.kattis.com/problems?order=%2Bdifficulty_category
// https://open.kattis.com/ranklist/countries
// https://open.kattis.com/ranklist/universities
// https://open.kattis.com/users/dariush-tasdighi
// https://open.kattis.com/users/dariush-tasdighi/settings
// https://open.kattis.com/help/csharp

// https://exercism.org/
// https://leetcode.com/
// https://coderbyte.com/
// https://www.codewars.com/
// https://www.topcoder.com/
// https://projecteuler.net/
// https://teamtreehouse.com/
// https://www.hackerrank.com/
// **************************************************
// **************************************************
// **************************************************

// **************************************************
// **************************************************
// **************************************************
//namespace Hello
//{
//	internal static class Program
//	{
//		private static void Main()
//		{
//			System.Console.WriteLine(value: "Hello World!");
//		}
//	}
//}
// **************************************************
// **************************************************
// **************************************************

// **************************************************
// **************************************************
// **************************************************
//namespace FindingAnA
//{
//	internal static class Program
//	{
//		private static void Main()
//		{
//			string line;

//			while ((line = System.Console.ReadLine()) != null)
//			{
//				var index =
//					line.IndexOf(value: 'a');

//				if (index != -1)
//				{
//					string result =
//						line.Substring(startIndex: index);

//					// Note: The below code does not support in Kattis!
//					//string result = line[index..];

//					System.Console.WriteLine(value: result);
//				}
//			}
//		}
//	}
//}
// **************************************************
// **************************************************
// **************************************************

// **************************************************
// **************************************************
// **************************************************
//namespace Autori
//{
//	internal static class Program
//	{
//		private static void Main()
//		{
//			string line;

//			while ((line = System.Console.ReadLine()) != null)
//			{
//				//var items =
//				//	line.Split(separator: '-');

//				//var items =
//				//	line.Split(separator: new char[] { '-' });

//				//var items =
//				//	line.Split(separator: new char[] { '-' },
//				//	options: System.StringSplitOptions.None);

//				var items =
//					line.Split(separator: new char[] { '-' },
//					options: System.StringSplitOptions.RemoveEmptyEntries);

//				// Note: 'TrimEntries' Does not support in Kattis!
//				//var items =
//				//	line.Split(separator: new char[] { '-' },
//				//	options: System.StringSplitOptions.TrimEntries);

//				// Note: 'TrimEntries' Does not support in Kattis!
//				//var items =
//				//	line.Split(separator: new char[] { '-' },
//				//	options: System.StringSplitOptions.TrimEntries
//				//	| System.StringSplitOptions.RemoveEmptyEntries);

//				var result =
//					string.Empty; // ""

//				foreach (var item in items)
//				{
//					result +=
//						item.Substring(startIndex: 0, length: 1);

//					// Note: The modern below command does not support in Kattis!
//					//result += item[..1];
//				}

//				System.Console.WriteLine(value: result);
//			}
//		}
//	}
//}
// **************************************************
// **************************************************
// **************************************************

// **************************************************
// **************************************************
// **************************************************
//namespace WhichIsGreater
//{
//	internal static class Program
//	{
//		private static void Main()
//		{
//			string line;

//			while ((line = System.Console.ReadLine()) != null)
//			{
//				var items =
//					line.Split(separator: new char[] { ' ' },
//					options: System.StringSplitOptions.RemoveEmptyEntries);

//				var firstNumber =
//					System.Convert.ToInt32(items[0]);

//				var secondNumber =
//					System.Convert.ToInt32(items[1]);

//				if (firstNumber <= secondNumber)
//				{
//					System.Console.WriteLine(value: "0");
//				}
//				else
//				{
//					System.Console.WriteLine(value: "1");
//				}
//			}
//		}
//	}
//}
// **************************************************
// **************************************************
// **************************************************

// **************************************************
// **************************************************
// **************************************************
//namespace TwoSum
//{
//	internal static class Program
//	{
//		private static void Main()
//		{
//			string line;

//			while ((line = System.Console.ReadLine()) != null)
//			{
//				var items =
//					line.Split(separator: new char[] { ' ' },
//					options: System.StringSplitOptions.RemoveEmptyEntries);

//				var firstNumber =
//					System.Convert.ToInt32(items[0]);

//				var secondNumber =
//					System.Convert.ToInt32(items[1]);

//				var resultNumber =
//					firstNumber + secondNumber;

//				System.Console.WriteLine(value: resultNumber);
//			}
//		}
//	}
//}
// **************************************************
// **************************************************
// **************************************************

// **************************************************
// **************************************************
// **************************************************
//namespace Tarifa
//{
//	internal static class Program
//	{
//		private static void Main()
//		{
//			int result = 0;

//			string xString = System.Console.ReadLine();
//			int x = System.Convert.ToInt32(value: xString);

//			//int x =
//			//	System.Convert.ToInt32
//			//	(value: System.Console.ReadLine());

//			string nString = System.Console.ReadLine();
//			int n = System.Convert.ToInt32(value: nString);

//			for (int index = 1; index <= n; index++)
//			{
//				string pString = System.Console.ReadLine();
//				int p = System.Convert.ToInt32(value: pString);

//				result += x - p;
//			}

//			result += x;

//			System.Console.WriteLine(value: result);
//		}
//	}
//}
// **************************************************
// **************************************************
// **************************************************




























//namespace MyApplication
//{
//	internal class Program : object
//	{
//		public Program() : base()
//		{
//		}

//		private static void Main()
//		{
//			string line;

//			while ((line = System.Console.ReadLine()) != null)
//			{
//				var items =
//					line.Split(separator: new char[] { ' ' },
//					options: System.StringSplitOptions.None);

//				long result = 1;

//				foreach (var item in items)
//				{
//					long itemLong =
//						System.Int64.Parse(s: item);

//					result *=
//						itemLong;
//				}

//				System.Console.WriteLine(result);
//			}
//		}
//	}
//}

//namespace MyApplication
//{
//	internal class Program : object
//	{
//		internal Program() : base()
//		{
//		}

//		private static void Main()
//		{
//			string line;

//			while ((line = System.Console.ReadLine()) != null)
//			{
//				var items =
//					line.Split(separator: new char[] { ';' },
//					options: System.StringSplitOptions.None);

//				long result = 0;

//				foreach (var item in items)
//				{
//					var subItems =
//						item.Split(separator: new char[] { '-' },
//						options: System.StringSplitOptions.None);

//					if (subItems.Length == 1)
//					{
//						result += 1;
//					}
//					else
//					{
//						var from =
//							System.Int64.Parse(s: subItems[0]);

//						var to =
//							System.Int64.Parse(s: subItems[1]);

//						result += to - from + 1;
//					}
//				}

//				System.Console.WriteLine(result);
//			}
//		}
//	}
//}

//namespace MyApplication
//{
//	internal class Program : object
//	{
//		internal Program() : base()
//		{
//		}

//		private static void Main()
//		{
//			var wordCountString =
//				System.Console.ReadLine();

//			var wordCount =
//				System.Int32.Parse(s: wordCountString);

//			var list =
//				new System.Collections.ArrayList();

//			for (int index = 1; index <= wordCount; index++)
//			{
//				var word =
//					System.Console.ReadLine();

//				if (index % 2 != 0)
//				{
//					list.Add(word);
//				}
//			}

//			foreach (var item in list)
//			{
//				System.Console.WriteLine(item);
//			}
//		}
//	}
//}

//namespace MyApplication
//{
//	internal class Program : object
//	{
//		internal Program() : base()
//		{
//		}

//		private static void Main()
//		{
//			string line;

//			while ((line = System.Console.ReadLine()) != null)
//			{
//				var items =
//					line.Split(separator: new char[] { ' ' },
//					options: System.StringSplitOptions.None);

//				double h =
//					System.Double.Parse(s: items[0]);

//				double b =
//					System.Double.Parse(s: items[1]);

//				double result = (h * b) / 2;

//				System.Console.WriteLine(result);
//			}
//		}
//	}
//}
