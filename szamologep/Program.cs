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
			Console.Write("Kérem adja meg az első számot: ");
			int a = Convert.ToInt32(Console.ReadLine());
			Console.Write("Kérem adja meg a második számot: ");
			int b = Convert.ToInt32(Console.ReadLine());
			Console.Write("Az elvégezendő művelet jele: ");
			char jel = Convert.ToChar(Console.ReadLine());
			indit(a, b, jel);
		}
	}
}
