using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace szamologep
{
	internal class Program
	{
		static int osszeadas(int a, int b)
		{
			return a + b;
		}
		static int kivonas(int a, int b)
		{
			return a - b;
		}
		static int szorzas(int a, int b)
		{
			return a * b;
		}
		static double osztas(int a, int b)
		{
			return a / b;
		}
		static string szazalek(int a, int b)
		{
			return Convert.ToString(a / b * 100) + "%";
		}
		static void Main(string[] args)
		{
		}
	}
}
