using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NovemberProjektet
{
	class Program
	{
		static void Main(string[] args)
		{
			Fighter Player1 = new Fighter();
			string GameName = @"
    _____ _               ______ _       _ _
  / ____ | |             | ____(_) | |   | |
 | (___ | | _ __ _ _ __  | | __   _ __ _ | | __ | | _
  \___ \| __ / _` | '__| |  __| | |/ _` | '_ \| __ |
   ____) | || (_ | | |    | |    | | (_ | | | | | | _
  | _____ / \__\__,_ | _ |    | _ |    | _ |\__, | _ | | _ |\__ |
												 __ / |
			  
												| ___ /";
			Console.WriteLine(GameName);
			Console.WriteLine("Välkommen! Var god och välj en karaktär du vill ha");
			Player1.FighterChoice();
			Console.ReadKey();
		}
	}
}
