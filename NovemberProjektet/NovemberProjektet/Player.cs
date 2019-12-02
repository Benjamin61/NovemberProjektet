using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NovemberProjektet
{
	 public class Player : Fighter
	{
		static Random generator = new Random();
	}
	public override int SetHp()
	{
		base.SetHp();
		hp.gen.Next(400, 700);
	}
	public override int 
}
