using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NovemberProjektet
{
	public class Enemy : Fighter //En klass som heter enemy och ärver från Fighter
	{
		
		
		static Random enemysGenerator = new Random(); //En static generator som används i hela metoden. detta då random basera på klockslag i c# så det är egentligt inte random om det skapas men än 1 variabel


		public override int dmgDone() //metoden dmgdone från fighter fast men override så den blir sin egna
		{
			int dmg = base.dmgDone(); //Base används för att köra grund metoden dmg done vilket lagras i inten dmg
			dmg = dmg / 2 + 1; //Gör så att dmg blir hälften +1 för enemy
			Console.WriteLine(name + " gjorde " + dmg + " dmg");
			return dmg; //Retunerar hur mkt dmg en enemy gör
		}

		public override int SetHp() //Som tidigare fast nu för hp
		{
			hp = base.SetHp(); //Gör metoden sethp och lagrar värdet i en int

			hp = enemysGenerator.Next(40, 80); //Gör om värdet till något mellan 40,80 hp
			//hp = enemysGenerator.Next(400, 550);
			return hp; //Retunerar hp
		}
		public void whatEnemy() //En metod för att få fram 1 av 5 enemys. Det ideal vore om jag kunde använda mig av en api för namn
		{
			List<string> enemies = new List<string> { "Enemy 1", "Enemy 2", "Enemy 3", "Enemy 4", "Enemy 5" };
			name = enemies[enemysGenerator.Next(5)]; //Väljer ett av det 5 slotsen i stringen. Varje slot har ett namn
			Console.WriteLine("Din motståndare är " + name); //Skriver ut vem ens motståndare är
			
			
		}

		

	}
}
