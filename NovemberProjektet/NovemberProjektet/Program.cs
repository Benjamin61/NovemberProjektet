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
______ _       _     _     _____ _                 _       _             
|  ___(_)     | |   | |   /  ___(_)               | |     | |            
| |_   _  __ _| |__ | |_  \ `--. _ _ __ ___  _   _| | __ _| |_ ___  _ __ 
|  _| | |/ _` | '_ \| __|  `--. \ | '_ ` _ \| | | | |/ _` | __/ _ \| '__|
| |   | | (_| | | | | |_  /\__/ / | | | | | | |_| | | (_| | || (_) | |   
\_|   |_|\__, |_| |_|\__| \____/|_|_| |_| |_|\__,_|_|\__,_|\__\___/|_|   
          __/ |                                                          
         |___/                                                           
";
			Console.WriteLine(GameName);
            Console.WriteLine("Testar");
			Player1.FighterChoice();
			
			
			Console.ReadKey();
		}
	}
}
