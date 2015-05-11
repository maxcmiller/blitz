﻿using System;
using Rocket.RocketAPI;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Blitz
{
	public class BlitzConfiguration : IRocketConfiguration
	{
		[XmlArrayItem (ElementName = "Unit")]
		public List<Unit> Units;

		[XmlArrayItem (ElementName = "Team")]
		public List<Team> Teams;

		public IRocketConfiguration DefaultConfiguration {
			get {
				return new BlitzConfiguration {
					Units = new List<Unit> {
						new Unit {
							Name = "Rifleman",
							Default = true,
							Loadout = new List<UnitItem> {
								new UnitItem (101, 1),
								new UnitItem (103, 3),
								new UnitItem (44, 1)
							}
						}
					},
					Teams = new List<Team> {
						new Team {
							Name = "Red",
							Players = new List<PlayerData> {
								new PlayerData ("76561198078287506", "GENERAL", "Rifleman")
							},
							Spawns = new List<Spawn> {
								new Spawn(-77.30339f, 36.246357f, 512.0219f, "Default")
							}
						},
						new Team {
							Name = "Blue",
							Players = new List<PlayerData> {
								new PlayerData ("76561198080555614", "GENERAL", "Rifleman")
							},
							Spawns = new List<Spawn> {
								new Spawn(-77.30339f, 36.246357f, 512.0219f, "Default")
							}
						}
					}
				};
			}
		}
	}
}

