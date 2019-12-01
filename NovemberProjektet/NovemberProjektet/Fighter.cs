using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NovemberProjektet
{
	pblic class Fighter
	{
		public float Dmg;
		public float hp;
		public string name;
		public virtual float SetStats() //Metod som slumpar fram hp
		{
			Random generator = new Random();
			hp = generator.Next(100, 170);
			return hp;
		}
		public virtual float Dmg() //Metod som slumpar fram dmg
		{
			Random generator = new Random();
			 Dmg = generator.Next (15,25);
        }

		public void Hurt() //Metod som gör själv attacken och tar bort från hp
		{
			hp = hp - Dmg;
		}
		/*public string name; //Strings för att lagra informationen som körs i metoderna
		private int hp;
		public int SetHp() //Metod som används för att genererar random hp till båda karaktärerna
		{
			Random generator = new Random(); //Random generator
			hp = generator.Next(20, 41); //Sätter in ett random nummer mellan 20 och 40 till inten hp
			return hp; //retunerar värdet från det som körs ovan
		}


		//List<string> FighterName = new List<string>();//
		public string NameDecide() //Metod för att namnge spelarna
		{

			name = Console.ReadLine(); // stringen name = spelarens input
			Console.WriteLine("Du namngav spelaren: [" + name + "]");


			return name; //retunerar stringen
		}

		public int Attack() //Metod som avger hur mycket damage man ska göra
		{
			Random generator = new Random();
			int dmg = generator.Next(2, 7); //Skapar en int som får ett värde från generatorn mellan 2 och 6
			return dmg; //Retunerar int dmg med ett värde

		}

		public void Hurt(int dmg) //Metod som tar hp minus dmg från tidigare metoder
		{
			hp = hp - dmg; //Gör om hp till hp - dmg

			if (hp < 0) //Om man tar skada så att ens hp bli under 0 så kommer det bara displaya 0, man kan inte ha negativt hp
			{
				hp = 0;
			}
		}

		public int GetHp() //Metod som skriver ut spelarens hp
		{

			Console.WriteLine(name + " har nu " + hp + "hp."); //Skriver ut hp man har nu

			return hp; //Retunerar hp

		}


		public bool IsAlive() //En bool för att kolla så att spelaren är vid liv
		{
			bool enoughHP = false; //Sätter boolen enoughHP till false som default

			if (hp >= 1) //Om spelarens hp är större eller lika med 1 så är enoughHP true
			{
				enoughHP = true;
			}




			return enoughHP; //Retunerar boolen enoughHP*/

		}

	}
	/*class Fighter
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
        		public string name; //Strings för att lagra informationen som körs i metoderna
		private int hp;
		public int SetHp() //Metod som används för att genererar random hp till båda karaktärerna
		{
			Random generator = new Random(); //Random generator
			hp = generator.Next(20, 41); //Sätter in ett random nummer mellan 20 och 40 till inten hp
			return hp; //retunerar värdet från det som körs ovan
		}


		//List<string> FighterName = new List<string>();//
		public string NameDecide() //Metod för att namnge spelarna
		{
			
			name = Console.ReadLine(); // stringen name = spelarens input
			Console.WriteLine("Du namngav spelaren: [" + name + "]" );

			
			return name; //retunerar stringen
		}

		public int Attack() //Metod som avger hur mycket damage man ska göra
		{
			Random generator = new Random();
			int dmg = generator.Next(2, 7); //Skapar en int som får ett värde från generatorn mellan 2 och 6
			return dmg; //Retunerar int dmg med ett värde

		}

		public void Hurt(int dmg) //Metod som tar hp minus dmg från tidigare metoder
		{
			hp = hp - dmg; //Gör om hp till hp - dmg

			if (hp < 0) //Om man tar skada så att ens hp bli under 0 så kommer det bara displaya 0, man kan inte ha negativt hp
			{
				hp = 0;
			}
		}

		public int GetHp() //Metod som skriver ut spelarens hp
		{

			Console.WriteLine(name + " har nu " +  hp + "hp."); //Skriver ut hp man har nu

			return hp; //Retunerar hp
			
		}


		public bool IsAlive() //En bool för att kolla så att spelaren är vid liv
		{
			bool enoughHP = false; //Sätter boolen enoughHP till false som default

			if (hp >= 1) //Om spelarens hp är större eller lika med 1 så är enoughHP true
			{
				enoughHP = true;
			}




			return enoughHP; //Retunerar boolen enoughHP
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






	//}
}
