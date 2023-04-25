﻿using Engine.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine.ViewModels;

internal class GameSession
{

	public Player CurrentPlayer { get; set; }

	public GameSession()
	{
		CurrentPlayer = new Player
		{
			Name = "Salar",
			Gold = 1000000
		};
	}


}
