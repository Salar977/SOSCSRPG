using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine.Models;

public class Player
{
	public string Name { get; set; } = "Hero";
	public string CharacterClass { get; set; } = $"{Characters.Warrior}";
	public int HitPoints { get; set; } = 10;
	public int ExperiencePoints { get; set; }
	public int Level { get; set; } = 1;
	public int Gold { get; set; } = 25;


	
}
public enum Characters
{
	Warrior = 1,
	Ranger,
	Mage
}