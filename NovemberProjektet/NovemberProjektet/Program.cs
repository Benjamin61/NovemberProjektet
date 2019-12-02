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
			Fighter f1 = new Fighter(); //här skapas alla klasser som behövs för spelet
			Player p1 = new Player();
			Enemy e1 = new Enemy();
			string GameName = @"
______ _       _     _     _____ _                 _       _             
|  ___(_)     | |   | |   /  ___(_)               | |     | |            
| |_   _  __ _| |__ | |_  \ `--. _ _ __ ___  _   _| | __ _| |_ ___  _ __ 
|  _| | |/ _` | '_ \| __|  `--. \ | '_ ` _ \| | | | |/ _` | __/ _ \| '__|
| |   | | (_| | | | | |_  /\__/ / | | | | | | |_| | | (_| | || (_) | |   
\_|   |_|\__, |_| |_|\__| \____/|_|_| |_| |_|\__,_|_|\__,_|\__\___/|_|   
          __/ |                                                          
         |___/                                                           
";//Skriver ut texten ovan. Ascii art format. Lagras ascii arten i en string
			Console.WriteLine(GameName); //Skriver ut stringen ovan
			Console.WriteLine("Målet med detta spel är att du ska klara dig så lång som möjligt ");
			Console.WriteLine("För varje stage så kommer dina stats att minska");
			Console.WriteLine("Klicka enter när du är redo");
			Console.ReadKey();
			Console.Clear(); //Raderar texten i konsolen
			p1.PlayerName(); //kör metoden playername för p1 så man får välja ett namn
			p1.SetHp(); //får sitt hp från metoden SetHp
			e1.SetHp(); //får sitt hp från metoden SetHp
			int stage = 0; //En int som används för att hålla koll på vilken stage man är på
			int input; //En int där spelarens input lagras i efter en transformation från en string

			while (stage < 1000 && p1.anyoneDead()) //Så länge stage är under 1000(Alltså typ förevigt) eller tills p1 dör körs metoden
			{
				Console.WriteLine("Vad vill du göra?");
				Console.WriteLine("[1]Fortsätt [2]Stats [3]Avsluta");
				input = CorrectInput(); //Säger att inten input = correctInput och kör den dvs att choice = input
				if (input == 1) //Om spelares val är 1 kommer Battle köras med parametrarna p1,e1, och stage
				{
					stage = Battle(p1, e1, stage);
				}
				if (input == 2) //här finner man stats för alla olika typer av karaktären (Tank,Goblin etc som jag inte hann med)
				{
					Console.WriteLine("Stats är tyvärr inte klart");
				}
				if (input == 3) //Spelet avslutas
				{
					System.Environment.Exit(1); //Spelet avslutas
				}

			}

		}
		static int CorrectInput()
		{
			string input = Console.ReadLine(); //lagras spelarens svar i en string som heter input
			bool translate = int.TryParse(input, out int choice); //En bool som kallas translate = en tryparse
			while (!translate || choice != 1 && choice != 2 && choice != 3) //Om tryparsen inte lyckas eller svaret inte något annat än 1,2,3 kör while loopen
			{
				Console.WriteLine("Tänke på att svara 1, 2, eller 3 i siffror.");
				Console.WriteLine("[1]Fortsätt [2]Stats [3]Avsluta");
				Console.Write("Försök igen:");

				input = Console.ReadLine();
				translate = int.TryParse(input, out choice);
			}
			return choice; //Retunerar spelarens svar i int from med namnet choice
			
		}
		void Stats() //Stats
		{
			Console.WriteLine("Här finner du stats för alla karaktärer");
			Console.ReadKey();
			
		}
		static int Battle(Player p1, Enemy e1, int stage) //Fight metoden som kommer köras varje gång man väljer att fortsätta
		{
			if (!e1.anyoneDead()) //Dennas applicerar mest på stage nr 1. Dvs andra fighten. Då kommer enemy att vara död och därför måste vi skapa en ny
			{
				e1 = new Enemy(); //Skapar en ny enemy som ersätter den döde
			}
			e1.whatEnemy(); //Bestämmer vilken enemy
			e1.SetHp(); //Ger enemyn ett hp
			while (p1.anyoneDead() && e1.anyoneDead()) //Så länge e1 och p1 lever körs while loopen
			{
				p1.HighOrLow(); //p1 får välja mellan en HighOrLow attack (Skickas till den metoden)
				int attack = p1.dmgDone(); //Skapar en int som kallas attack. resultat från metoden dmgDone lagras
				e1.Hurt(attack); //Hurt metoden körs med parametern attack på enemy1
				e1.HPLeft(); //Skriver ut hur mycket hp enemy 1 har
				//Notera att här kan man göra så att enemy dör direkt om den har 0 hp, Vill dock ha så att båda får 1 varsitt slag innan man checkar om någon är död så det blir mer rättvist.
				attack = e1.dmgDone(); //Samma som ovan fast tvärtom
				p1.Hurt(attack);
				p1.HPLeft();
			}
			if (!p1.anyoneDead() && e1.anyoneDead()) //Om p1.anyonedead blir fasle dvs man är på 0hp så förlorar man och denna if sats kör
			{
				Console.WriteLine("Du dog");
				Console.WriteLine("Var inte ledsen över det! du klara dig " + stage + " stages");

				
			}
			if (!e1.anyoneDead() && p1.anyoneDead()) //tvärtom från ovan
			{
				Console.WriteLine("Du vann!");
				Console.WriteLine("Du besgrade din motståndare på stage " + stage); //skriver ut på vilken stage man var på
				stage = stage + 1; //lägger till 1 stage. Tanken var att ens stats skulle ändras lite med varje stage men vet inte riktigt hur man gör
				Console.WriteLine("Klicka enter för komma vidare");


			}
			else
			{
				Console.WriteLine("Det blev lika");//Om det blir lika så kommer man ändå förlorar sen eftersom while loopen inte kommer vilja starta men tänkte att man kan i allafall skriva ut det 
				Console.WriteLine("Nu har du 0hp och kommer därför inte att kunna köra igen");
				Console.WriteLine(" Men var inte ledsen över det! du klara dig " + stage + " stages");

			}
			Console.ReadKey();
			Console.Clear();
			return stage; //retunerar inten stage
			

		}
	}
}
	
		//Massor av extra kod där jag hade planer att ha med olika typer av gubbar(Goblins tank men hann inte.)

			/*Player p1 = new Player();
			Enemy e1 = new Enemy();
			Fighter f1 = new Fighter();
			int whatstage = 0;


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
			Console.WriteLine("Målet med detta spel är att du ska klara dig så lång som möjligt ");
			Console.WriteLine("För varje stage så kommer dina stats att minska");
			Console.WriteLine("Klicka enter när du är redo");
			Console.ReadKey();
			Console.Clear();
			p1.PlayerName();
			p1.SetHp();
			e1.SetHp();
			
			int choice;
			int stage;
			while (whatstage < 1000 && p1.anyoneDead())
			{
				/*Console.WriteLine("Vad vill du göra?");
				Console.WriteLine("[1]Fortsätta, [2]Avsluta");
				string playerAnswer = Console.ReadLine();
                 bool convertAnseer = int.TryParse(playerAnswer, out choice);
				while (!convertAnseer || )
				{
				}*/
				/*Console.WriteLine("Vad vill du göra?");
				Console.WriteLine("[1] Fortsätt [2] Uppgraderingar   [3] Avsluta");
				string input = Console.ReadLine();
				bool translateAnswer = int.TryParse(input, out choice);
				while (!translateAnswer || choice != 1 && choice != 2 && choice != 3)
				{
					Console.WriteLine("Prova igen");
					Console.WriteLine("[1] Fortsätt  [2] Avsluta");
					input = Console.ReadLine();
					translateAnswer = int.TryParse(input, out choice);
				}
				if (choice == 1)
				{
					whatstage = TriggerInstance(p1, e1, stage);
				}
				else if (choice == 2)
				{
					Console.WriteLine("För tillfället finns ingen shop");
					Console.WriteLine("Klicka enter för att komma vidare");
					Console.ReadKey();
				}
				else
				{
					Console.WriteLine("Klicka enter för att avsluta");
					Console.ReadKey();
				}



			}
		}

			static int triggerInstance()
			{
			}
			 
			//e1.SetHp();
			//fight();*/
			/* bool p1Alive = p1.anyoneDead();
			bool e1Alive = e1.anyoneDead();
			e1.SetHp();
			e1.whatEnemy();
			while (p1Alive == true && e1Alive == true)
			{

				//while (p1.anyoneDead() && e1.anyoneDead())
				//{
				p1.HighOrLow();
				int attack = p1.dmgDone();
				e1.Hurt(attack);
				e1.HPLeft();
				if (e1.anyoneDead())
				{
					attack = e1.dmgDone();
					p1.Hurt(attack);
					p1.HPLeft();
				}
			}
				//}
				if (p1Alive == false && e1Alive == true)
				{
					Console.WriteLine("Du dog. men du kom hela vägen till stage" + whatstage);
				}
				else
				{
					Console.WriteLine("Grattis du vann, och tog dig vidare till" + whatstage);
					whatstage = whatstage + 1;
				}*/
			
			 /*void fight(Player p1,)
			{
				
				e1.SetHp();
				e1.whatEnemy();
				while (p1.anyoneDead() && e1.anyoneDead())
				{
					p1.HighOrLow();
					int attack = p1.dmgDone();
					e1.Hurt(attack);
					e1.HPLeft();
					if (e1.anyoneDead())
					{
						attack = e1.dmgDone();
						p1.Hurt(attack);
						p1.HPLeft();
					}
				}
				if (!p1.anyoneDead() && e1.anyoneDead())
				{
					Console.WriteLine("Du dog. men du kom hela vägen till stage" + whatstage);
				}
				else
				{
					Console.WriteLine("Grattis du vann, och tog dig vidare till" + whatstage);
					whatstage = whatstage + 1;
				}
			}
			
			//f1.FighterChoice();

			/*void PlayerName()
			{
				Console.WriteLine("Vad ska din spelare heta?");
				name = Console.ReadLine();
				Console.WriteLine("Vilken klass vill du vara?");
				Console.WriteLine("[1] Assasin");
				Console.WriteLine("[2] Tank");
				Console.WriteLine("[3] Wizard");
				Console.WriteLine("[4] Goblin");
				Console.Write("Val:");
				string choice = Console.ReadLine();
				int choiceParse;
				bool Translate = int.TryParse(choice, out choiceParse);
				while (!Translate || choiceParse < 1 || choiceParse >= 5) //En while loop som körs så länge boolen inte lyckas eller choice parse inte är mellan 1 och 4
				{
					Console.WriteLine("Ogiltigt svar, prova igen!");
					choice = Console.ReadLine();
					Translate = int.TryParse(choice, out choiceParse);
				}
				if (choiceParse == 1) //Spelaren input = 1
				{
					Console.WriteLine("Du valde Assasin!");
					Assasin a1 = new Assasin();
					//AssasinHP(); //Skickas till metoden


				}
				if (choiceParse == 2)
				{







					Console.WriteLine("Du valde Tank!");
					Tank T1 = new Tank();
				}
				if (choiceParse == 3)
				{
					Console.WriteLine("Du valde Wizard!");
					Wizard W1 = new Wizard();
				}
				if (choiceParse == 4)
				{
					Console.WriteLine("Du valde Goblin!");
					Goblin G1 = new Goblin();
				}
			}*/
			/*Fighter A = new Fighter(); //Skapar 2 fighter från classen som kallas A respektive B
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
			/*Fighter A = new Fighter(); //Skapar 2 fighter från classen som kallas A respektive B
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
}*/
