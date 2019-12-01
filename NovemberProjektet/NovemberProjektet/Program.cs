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
			/*Fighter Player1 = new Fighter();
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
            Console.WriteLine("Testaren");
			Player1.FighterChoice();
			
			Fighter A = new Fighter(); //Skapar 2 fighter från classen som kallas A respektive B
			Fighter B = new Fighter();
			Console.Write("Ge ett namn till spelare A:");
			string Anamn = A.NameDecide(); //Gör en string som kallas Anamn som = Namdecide metoden för fighter A 
			A.SetHp(); //Kör metoden sethp för Fighter A
			bool Aalive = A.IsAlive(); //Skapar en bool som heter  Aalive = metoden IsAlive för A
			Console.Write("Namnge spelare B:");
			string Bnamn = B.NameDecide(); //Samma sak som ovan fast nu applicerars det på spelare B
			B.SetHp();
			bool Balive = B.IsAlive();
			Console.ReadKey();
			while (Balive == true && Aalive == true)  //En loop som körs så länge metoden IsAlive i figter.cs är true
			{
				
				int attackA = A.Attack(); //Skapar en int där information från A.Attack lagras
				B.Hurt(attackA); //Hurt metoden körs för B där attacken från tidigare förs med i en int
				Console.WriteLine(Anamn + " Gjorde " + attackA + " Skada"); //Skriver ut hur mycket dmg man gjorde
				B.GetHp(); //Skriver ut fighters B hp
				Balive = B.IsAlive(); //Kollar så fighter B är alive
				Console.ReadKey();
				int attackB = B.Attack(); //Lagrar fighter b attack i en int
				Console.WriteLine(Bnamn + " Gjorde " + attackB + " Skada");
				A.Hurt(attackB); //Kör metoden hur men B attack in skada tagen
				A.GetHp(); //Skriver ut A:s hp
				Aalive = A.IsAlive(); //kollar så fighter a är alive
				Console.ReadKey();
				Console.Clear(); //Clearar konsolen
			}

			if (Aalive == true && Balive == false) //Om Figthers A bool är true dvs den har 1 eller mer hp medans B inte har det så vinner A
			{
				Console.WriteLine(Anamn + " vann duellen!");

			} 
			else if (Aalive == false && Balive == true) //Motsatt till ovan. 
			{
				Console.WriteLine(Bnamn + " vann duellen!");
			}
			else { Console.WriteLine("oavgjort!"); } //Annars bli det oavgjort

			Console.ReadKey();

			
			Console.ReadKey();*/
			Fighter A = new Fighter(); //Skapar 2 fighter från classen som kallas A respektive B
			Fighter B = new Fighter();
			Console.Write("Ge ett namn till spelare A:");
			string Anamn = A.NameDecide(); //Gör en string som kallas Anamn som = Namdecide metoden för fighter A 
			A.SetHp(); //Kör metoden sethp för Fighter A
			bool Aalive = A.IsAlive(); //Skapar en bool som heter  Aalive = metoden IsAlive för A
			Console.Write("Namnge spelare B:");
			string Bnamn = B.NameDecide(); //Samma sak som ovan fast nu applicerars det på spelare B
			B.SetHp();
			bool Balive = B.IsAlive();
			Console.ReadKey();
			while (Balive == true && Aalive == true)  //En loop som körs så länge metoden IsAlive i figter.cs är true
			{

				int attackA = A.Attack(); //Skapar en int där information från A.Attack lagras
				B.Hurt(attackA); //Hurt metoden körs för B där attacken från tidigare förs med i en int
				Console.WriteLine(Anamn + " Gjorde " + attackA + " Skada"); //Skriver ut hur mycket dmg man gjorde
				B.GetHp(); //Skriver ut fighters B hp
				Balive = B.IsAlive(); //Kollar så fighter B är alive
				Console.ReadKey();
				int attackB = B.Attack(); //Lagrar fighter b attack i en int
				Console.WriteLine(Bnamn + " Gjorde " + attackB + " Skada");
				A.Hurt(attackB); //Kör metoden hur men B attack in skada tagen
				A.GetHp(); //Skriver ut A:s hp
				Aalive = A.IsAlive(); //kollar så fighter a är alive
				Console.ReadKey();
				Console.Clear(); //Clearar konsolen
			}

			if (Aalive == true && Balive == false) //Om Figthers A bool är true dvs den har 1 eller mer hp medans B inte har det så vinner A
			{
				Console.WriteLine(Anamn + " vann duellen!");

			}
			else if (Aalive == false && Balive == true) //Motsatt till ovan. 
			{
				Console.WriteLine(Bnamn + " vann duellen!");
			}
			else { Console.WriteLine("oavgjort!"); } //Annars bli det oavgjort

			Console.ReadKey();
		}
	}
}
