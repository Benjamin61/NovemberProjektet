using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NovemberProjektet
{
	 public class Enemy : Fighter
	{
		private int EnemyStage = 1; //Enemy startar på stage 1.
		 Random enemyStatsGenerator = new Random();

		
        public override float dmgDone()
		{
			float Edmg = base.dmgDone();
				return Edmg;
		}

		public override float SetStats()
		{
			 base.SetStats();
			hp = enemyHpGenerator.Next(400, 550);
		}
		public void whatEnemy()
		{
		  List<string> enemies = new List<string> {"Enemy 1","Enemy 2","Enemy 3","Enemy 4","Enemy 5"};
			name = enemies[enemyStatsGenerator.Next(5)];
			Console.WriteLine("Din motståndare är" + name);
			Console.WriteLine("[Stage" + EnemyStage + "]");
		}
		public int newStage()
			{
               EnemyStage = EnemyStage + 1;
			}
	}
}
