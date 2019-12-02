using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NovemberProjektet
{
	public class Fighter
	{


		public string name; //Här är alla olika datatyper //Public för att man ska kunna välja namn från main
		protected int stage = 0; //De andra är protected så att man enbart kommer åt dom från just denna klass och dess metoder eller de klasser om ärver från fighter
		protected int hp = 0;
		protected int choice = 0;
		protected bool isDead = true;
		protected int dmg = 0;
		public virtual int SetHp() //Metod som slumpar fram hp //Då dessa metoder kommer användas av t,ex player och enemy så ska det vara en virtual
		{//På så sätt kommer jag genom en override att kunna göra en egen version av metodern som är virtual
			Random generator = new Random(); //En metod som sätter hp för en karatkrä som lagras i intet hp
			hp = generator.Next(50, 60);
			//hp = generator.Next(100, 170);
			return hp;
		}
		public virtual int dmgDone() //Metod som slumpar fram dmg //Denna kan ändras senare av andra klasser då den är virtual
		{
			Random generator = new Random();

			if (choice == 1)
			{
				dmg = generator.Next(5, 40);
			}
			else
			{
				dmg = generator.Next(15, 25);
			}

			return dmg;
		}

		public void Hurt(int taken) //Metod med en parametar där en int tas med utifrån metoden
		{
			hp = hp - taken;
			if (hp < 0)
			{
				hp = 0; //När hp går under 0 sätts det till 0 eftersom man inte ka ha negativt med hp
			}
		}
		public bool anyoneDead() //En bool som checkar om någon är död
		{
			if (hp == 0) //När hp blir till 0 så ändras boolen till false och retunerar
			{
				isDead = false;
			}
			return isDead;

		}

		public int HPLeft() //En int metod som checkar hur mycket hp man har kvar och retunerar det sen
		{
			Console.WriteLine(name + "har nu " + hp + "hp");
			Console.WriteLine("Klick enter för att fortsätta");
			Console.ReadKey();
			return hp;

		}
		public int HighOrLow() //En  int som får fram spelarens val. Denna behöver dock inte vara virtual
		{
			Console.WriteLine("Vill du göra en Hög risk attack[1] eller Låg risk[2]?");
			Console.WriteLine("Var vänlig och skriv 1 eller 2");
			string input = Console.ReadLine(); //Lagrar spelaren input i en string
			bool correctInput = int.TryParse(input, out choice); //Försöker göra om spelarens input till en int
			while (!correctInput || choice != 1 && choice != 2) //Om boolen misslyckas kommer den loop köras. Dock skulle loopen inte köras om man satte in t,ex 20 eftersom boolen är då lyckas. Därav att svaret måste vara 1 eller 2 också
			{
				Console.WriteLine("Skriv 1 eller 2");
				Console.WriteLine("Kom ihåg att bara svara i siffror");
				input = Console.ReadLine(); //Lagrar inputen igen
				correctInput = int.TryParse(input, out choice); //Kör om boolen igen
			}
			if (choice == 1)
			{
				Console.WriteLine("Du valde en hög risk");
			}
			else
			{
				Console.WriteLine("Du valde en låg risk");
			}
			return choice;
		}

		public int NextStage() //En int som håller koll på vilken stage man är på och adderar 1 på ens stage när man besegrar en boss
		{
			stage = stage + 1;
			return stage;

		}
	}
}
	
	