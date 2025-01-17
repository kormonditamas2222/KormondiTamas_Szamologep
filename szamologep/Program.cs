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
		static double osztas(double a, double b)
		{
			return a / b;
		}
		static string szazalek(double a, double b)
		{
			return Convert.ToString(a / b * 100) + "%";
		}
		static void indit(int a, int b, char muveleti_jel)
		{
			switch (muveleti_jel)
			{
				case '+': Console.WriteLine("A két szám összege: " + osszeadas(a, b)); break;
				case '-': Console.WriteLine("A két szám különbsége: " + kivonas(a, b)); break;
				case '*': Console.WriteLine("A két szám szorzata: " + szorzas(a, b)); break;
				case '/': Console.WriteLine("A két szám hányadosa: " + osztas(a, b)); break;
				case '%': Console.WriteLine("A két szám százaléka: " + szazalek(a, b)); break;
                default: break;
			}
		}
		static void Main(string[] args)
		{
			Console.Write("Kérem adja meg az első számot: ");
			int elso = Convert.ToInt32(Console.ReadLine());
			Console.Write("Kérem adja meg a második számot: ");
			int masodik = Convert.ToInt32(Console.ReadLine());
			Console.Write("Az elvégezendő művelet jele: ");
			char jel = Convert.ToChar(Console.ReadLine());
			indit(elso, masodik, jel);
		}
	}
}
