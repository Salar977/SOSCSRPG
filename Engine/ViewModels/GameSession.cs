using Engine.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine.ViewModels;

public class GameSession
{
	public World CurrentWorld { get; set; }
	public Player CurrentPlayer { get; set; }
	public Location CurrentLocation { get; set; }

	public GameSession()
	{
		CurrentPlayer = new Player
		{
			Name = "Salar",
			CharacterClass = Characters.Warrior.ToString(),
			HitPoints = 10,
			ExperiencePoints = 0,
			Level = 1,
			Gold = 25
		};

		CurrentLocation = new Location
		{
			XCoordinate = 0,
			YCoordinate = -1,
			Name = "Home",
			Description = "This is your home!",
			ImageName = "pack://application:,,,/Engine;component/Images/Locations/Home.png"
		};

		CurrentWorld = new World();
	}


}
