using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NovemberProjektet
{
	class Fighter
	{
		public int hp = 100;
		public int attack = 5;
		public int FighterChoice()
		{


			Console.WriteLine("Välkommen! Var god och välj en karaktär du vill ha, välj med hjälp av siffrorna.");
			Console.WriteLine("[1] Assasin");
			Console.WriteLine("[2] Tank");
			Console.WriteLine("[3] Wizard");
			Console.WriteLine("[4] Goblin");
			Console.Write("Val:");
			string choice = Console.ReadLine();
			int choiceParse;
			bool Translate = int.TryParse(choice, out choiceParse);
			while (!Translate || choiceParse <1 || choiceParse >=5 ) //En while loop som körs så länge boolen inte lyckas eller choice parse inte är mellan 1 och 4
			{
				Console.WriteLine("Ogiltigt svar, prova igen!");
				choice = Console.ReadLine();
				Translate = int.TryParse(choice, out choiceParse);
			}
			if (choiceParse == 1) //Spelaren input = 1
			{
				Console.WriteLine("Du valde Assasin!");
				//AssasinHP(); //Skickas till metoden
				Console.WriteLine(hp);

			}
			if (choiceParse == 2)
			{
				



                                                        

				
				Console.WriteLine("Du valde Tank!");
			}
			if (choiceParse == 3)
			{
				Console.WriteLine("Du valde Wizard!");
			}
			if (choiceParse == 4)
			{
				Console.WriteLine("Du valde Goblin!");
			}




			return choiceParse;
		}

		/*public int AssasinHP()
		{
			List<int> AssasinStats = new List<int>();
			hp = hp / 2;
			attack = attack * 2;
			AssasinStats.Add(hp);
			AssasinStats.Add(attack);
			return List;

			/*int[] AssasinStats = {hp, attack};
			return AssasinStats;*/
		//}






	}
}
