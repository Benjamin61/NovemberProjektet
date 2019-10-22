using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NovemberProjektet
{
	class Fighter
	{
		public string FighterChoice()
		{
			Console.WriteLine("[1] Assasin");
			Console.WriteLine("[2] Tank");
			Console.WriteLine("[3] Wizard");
			Console.WriteLine("[4] Martinis");
			string choice = Console.ReadLine();
			Console.WriteLine(choice);
			return choice;
		}
	}
}
