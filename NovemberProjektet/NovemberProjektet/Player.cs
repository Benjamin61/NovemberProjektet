using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NovemberProjektet
{
	public class Player : Fighter //Klassen player som ärver från fighter
	{
		static Random generator = new Random(); //En generator som är för hela klassen
		public override int SetHp() //Samma princip som för enemy.
		{
			base.SetHp();
			hp = generator.Next(300, 600);
			//hp = generator.Next(400, 700);
			return hp;
		}
		public override int dmgDone() //Samma som ovan
		{
			int dmg = base.dmgDone();
			dmg = dmg + 40;
			Console.WriteLine(name + " gjorde " + dmg + " dmg");
			return dmg;
		}

		public void PlayerName() //Här får spelaren välja ett namn.
		{
			Console.WriteLine("Vad ska din spelare heta?");
			name = Console.ReadLine(); //Lagrar spelarens input i en string
			Console.WriteLine("Ditt namn är: " + name); //Skriver ut namnt
		}
	}

}
