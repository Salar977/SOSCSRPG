using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine.Models;

public class Player : BaseNotificationClass
{
	private string? _name;
	private string? _characterClass;
	private int _hitPoints;
	private int _experiencePoints;
	private int _experienceForLeveling = 60;
	private int _level;
	private int _gold;
	public string Name
	{
		get { return _name; }
		set
		{
			_name = value;
			OnPropertyChanged(nameof(Name));
		}
	}
	public string CharacterClass
	{
		get { return _characterClass; }
		set
		{
			_characterClass = value;
			OnPropertyChanged(nameof(CharacterClass));
		}
	}
	public int HitPoints
	{
		get { return _hitPoints; }
		set
		{
			_hitPoints = value;
			OnPropertyChanged(nameof(HitPoints));
		}
	}
	public int ExperiencePoints
	{
		get { return _experiencePoints; }
		set
		{
			_experiencePoints = value;

			if (ExperiencePoints >= ExperienceForLeveling)
			{
				ExperienceForLeveling *= 2;
				Level++;
			}

			OnPropertyChanged(nameof(ExperiencePoints));
		}
	}
	public int ExperienceForLeveling
	{
		get { return _experienceForLeveling; }
		set
		{
			_experienceForLeveling = value;

			OnPropertyChanged(nameof(ExperienceForLeveling));
		}
	}
	public int Level
	{
		get { return _level; }
		set
		{
			_level = value;
			OnPropertyChanged(nameof(Level));
		}
	}
	public int Gold
	{
		get { return _gold; }
		set
		{
			_gold = value;
			OnPropertyChanged(nameof(Gold));
		}
	}
}

public enum Characters
{
	Warrior,
	Ranger,
	Mage
}