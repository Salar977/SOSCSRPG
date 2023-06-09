﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine.Models;

public class World
{
#pragma warning disable IDE0044 // Add readonly modifier
	private List<Location> _locations = new();
#pragma warning restore IDE0044 // Add readonly modifier

	internal void AddLocation(int xCoordinate, int YCoordinate, string name,
								string description, string imageName)
	{
		Location loc = new()
		{
			XCoordinate = xCoordinate,
			YCoordinate = YCoordinate,
			Name = name,
			Description = description,
			ImageName = imageName
		};

		_locations.Add(loc);
	}

	public Location? LocationAt(int xCoordinate, int yCoordinate)
	{
		foreach (Location loc in _locations)
		{
			if(loc.XCoordinate == xCoordinate && loc.YCoordinate == yCoordinate) return loc;
		}

		return null;
	}
}
