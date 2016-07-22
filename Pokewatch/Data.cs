﻿using System.Collections.Generic;
using Pokewatch.Datatypes;
using POGOProtos.Enums;

namespace Pokewatch
{
	public static class Data
	{
		//Hardcoded list of areas to search for pokemon.
		internal static readonly List<Region> Regions = new List<Region>
		{
			new Region
			{
				Name = "Whatcom Falls",
				Locations = new List<Location>
				{
					new Location {Latitude = 48.751776, Longitude = -122.429340},
					new Location {Latitude = 48.752929, Longitude = -122.427226},
					new Location {Latitude = 48.752491, Longitude = -122.433900},
					new Location {Latitude = 48.755391, Longitude = -122.425016},
					new Location {Latitude = 48.750422, Longitude = -122.427371},
				}
			},
			new Region
			{
				Name = "Bloedel Donovan Park",
				Locations = new List<Location>
				{
					new Location {Latitude = 48.760950, Longitude = -122.419008},
					new Location {Latitude = 48.758729, Longitude = -122.420017},
				}
			},
			new Region
			{
				Name = "Bellingham Marina",
				Locations = new List<Location>
				{
					new Location {Latitude = 48.753948, Longitude = -122.496942},
					new Location {Latitude = 48.754726, Longitude = -122.496191},
					new Location {Latitude = 48.753679, Longitude = -122.499490},
					new Location {Latitude = 48.754272, Longitude = -122.500920},
					new Location {Latitude = 48.755528, Longitude = -122.502048},
					new Location {Latitude = 48.757004, Longitude = -122.501803},
					new Location {Latitude = 48.757470, Longitude = -122.504305},
				}
			},
			new Region
			{
				Name = "Boulevard Park",
				Locations = new List<Location>
				{
					new Location {Latitude = 48.727091, Longitude = -122.505178},
					new Location {Latitude = 48.731160, Longitude = -122.502614},
					new Location {Latitude = 48.733099, Longitude = -122.500071},
				}
			},
			new Region
			{
				Name = "Maritime Heritage Park",
				Locations = new List<Location>
				{
					new Location {Latitude = 48.755100, Longitude = -122.483008},
					new Location {Latitude = 48.754091, Longitude = -122.482430},
					new Location {Latitude = 48.753114, Longitude = -122.483119},
				}
			},
			new Region
			{
				Name = "Elizabeth Park",
				Locations = new List<Location>
				{
					new Location {Latitude = 48.760314, Longitude = -122.491294},
					new Location {Latitude = 48.759699, Longitude = -122.490092},
				}
			},
			new Region
			{
				Name = "Bellingham Highschool",
				Locations = new List<Location>
				{
					new Location {Latitude = 48.757564, Longitude = -122.474716},
					new Location {Latitude = 48.757550, Longitude = -122.471830},
					new Location {Latitude = 48.755315, Longitude = -122.471862},
					new Location {Latitude = 48.755407, Longitude = -122.474845},
					new Location {Latitude = 48.756362, Longitude = -122.473236},
				}
			},
			new Region
			{
				Name = "Downtown",
				Locations = new List<Location>
				{
					new Location {Latitude = 48.746473, Longitude = -122.479566},
					new Location {Latitude = 48.747374, Longitude = -122.481131},
					new Location {Latitude = 48.747813, Longitude = -122.478256},
					new Location {Latitude = 48.748513, Longitude = -122.479576},
					new Location {Latitude = 48.749277, Longitude = -122.478138},
					new Location {Latitude = 48.750331, Longitude = -122.476668},
					new Location {Latitude = 48.749831, Longitude = -122.474853},
					new Location {Latitude = 48.747863, Longitude = -122.476363},
					new Location {Latitude = 48.751622, Longitude = -122.480606},
					new Location {Latitude = 48.750130, Longitude = -122.479780},
					new Location {Latitude = 48.751620, Longitude = -122.479030},
					new Location {Latitude = 48.751303, Longitude = -122.476941},
				}
			},
			new Region
			{
				Name = "Sehome Village",
				Locations = new List<Location>
				{
					new Location {Latitude = 48.732832, Longitude = -122.470581},
					new Location {Latitude = 48.731296, Longitude = -122.471976},
				}
			},
			new Region
			{
				Name = "Western Washington University",
				Locations = new List<Location>
				{
					new Location {Latitude = 48.739702, Longitude = -122.483944},
					new Location {Latitude = 48.738690, Longitude = -122.484738},
					new Location {Latitude = 48.737975, Longitude = -122.486712},
					new Location {Latitude = 48.736751, Longitude = -122.485210},
					new Location {Latitude = 48.735929, Longitude = -122.487793},
					new Location {Latitude = 48.735023, Longitude = -122.486194},
					new Location {Latitude = 48.733778, Longitude = -122.486430},
					new Location {Latitude = 48.732660, Longitude = -122.486301},
					new Location {Latitude = 48.731782, Longitude = -122.487395},
				}
			},
			new Region
			{
				Name = "Marine Park",
				Locations = new List<Location>
				{
					new Location {Latitude = 48.719128, Longitude = -122.515809},
					new Location {Latitude = 48.720526, Longitude = -122.513711},
					new Location {Latitude = 48.721252, Longitude = -122.510927},
				}
			},
			new Region
			{
				Name = "Cornwall Park",
				Locations = new List<Location>
				{
					new Location {Latitude = 48.770677, Longitude = -122.481795},
					new Location {Latitude = 48.771567, Longitude = -122.479944},
					new Location {Latitude = 48.772577, Longitude = -122.481917},
					new Location {Latitude = 48.773897, Longitude = -122.480475},
					new Location {Latitude = 48.775027, Longitude = -122.482418},
					new Location {Latitude = 48.775907, Longitude = -122.484071},
					new Location {Latitude = 48.776607, Longitude = -122.484800},
				}
			},
			new Region
			{
				Name = "Squalicum Creek Park",
				Locations = new List<Location>
				{
					new Location {Latitude = 48.766664, Longitude = -122.500923},
					new Location {Latitude = 48.767456, Longitude = -122.499668},
					new Location {Latitude = 48.767993, Longitude = -122.501352},
					new Location {Latitude = 48.769450, Longitude = -122.503616},
					new Location {Latitude = 48.769358, Longitude = -122.498423},
				}
			},
			new Region
			{
				Name = "Bellis Fair Mall",
				Locations = new List<Location>
				{
					new Location {Latitude = 48.784848, Longitude = -122.493328},
					new Location {Latitude = 48.787365, Longitude = -122.494369},
					new Location {Latitude = 48.787314, Longitude = -122.488652},
					new Location {Latitude = 48.784895, Longitude = -122.488666},
				}
			},
			new Region
			{
				Name = "Fairhaven",
				Locations = new List<Location>
				{
					new Location {Latitude = 48.721276, Longitude = -122.504045},
					new Location {Latitude = 48.719103, Longitude = -122.503144},
					new Location {Latitude = 48.720979, Longitude = -122.500945},
					new Location {Latitude = 48.718608, Longitude = -122.499722},
					new Location {Latitude = 48.717008, Longitude = -122.501052},
					new Location {Latitude = 48.721011, Longitude = -122.502301},
				}
			},
			new Region
			{
				Name = "Bayview Cemetary",
				Locations = new List<Location>
				{
					new Location {Latitude = 48.746803, Longitude = -122.442934},
					new Location {Latitude = 48.747652, Longitude = -122.438288},
					new Location {Latitude = 48.751387, Longitude = -122.444779},
					new Location {Latitude = 48.753353, Longitude = -122.441389},
					new Location {Latitude = 48.747873, Longitude = -122.446648},
				}
			},
			new Region
			{
				Name = "Civic Sports Center",
				Locations = new List<Location>
				{
					new Location {Latitude = 48.745187, Longitude = -122.459802},
					new Location {Latitude = 48.745173, Longitude = -122.456540},
					new Location {Latitude = 48.746885, Longitude = -122.456250},
					new Location {Latitude = 48.748371, Longitude = -122.455349},
					new Location {Latitude = 48.750043, Longitude = -122.456821},
					new Location {Latitude = 48.749880, Longitude = -122.459825},
					new Location {Latitude = 48.747715, Longitude = -122.460404},
				}
			},
			new Region
			{
				Name = "Rock Hill Park",
				Locations = new List<Location>
				{
					new Location {Latitude = 48.745703, Longitude = -122.466807},
				}
			},
			new Region
			{
				Name = "Broadway Park",
				Locations = new List<Location>
				{
					new Location {Latitude = 48.764957, Longitude = -122.479395},
					new Location {Latitude = 48.765212, Longitude = -122.475983},
					new Location {Latitude = 48.766188, Longitude = -122.473891},
				}
			},
			new Region
			{
				Name = "Sunset plaza",
				Locations = new List<Location>
				{
					new Location {Latitude = 48.774432, Longitude = -122.463641},
					new Location {Latitude = 48.774418, Longitude = -122.461474},
					new Location {Latitude = 48.774460, Longitude = -122.458856},
					new Location {Latitude = 48.773003, Longitude = -122.459425},
					new Location {Latitude = 48.772558, Longitude = -122.462172},
					new Location {Latitude = 48.771893, Longitude = -122.458556},
					new Location {Latitude = 48.771186, Longitude = -122.460680},
					new Location {Latitude = 48.769793, Longitude = -122.458416},
					new Location {Latitude = 48.769878, Longitude = -122.460454},
				}
			},
			new Region
			{
				Name = "Barkley Village",
				Locations = new List<Location>
				{
					new Location {Latitude = 48.770328, Longitude = -122.448739},
					new Location {Latitude = 48.770583, Longitude = -122.445950},
					new Location {Latitude = 48.770583, Longitude = -122.445950},
					new Location {Latitude = 48.769395, Longitude = -122.444770},
					new Location {Latitude = 48.768462, Longitude = -122.448311},
					new Location {Latitude = 48.772574, Longitude = -122.444449},
					new Location {Latitude = 48.771987, Longitude = -122.446734},
				}
			},
			new Region
			{
				Name = "Northridge Park",
				Locations = new List<Location>
				{
					new Location {Latitude = 48.772666, Longitude = -122.423314},
					new Location {Latitude = 48.774688, Longitude = -122.424258},
					new Location {Latitude = 48.776486, Longitude = -122.424571},
					new Location {Latitude = 48.778140, Longitude = -122.421809},
					new Location {Latitude = 48.775863, Longitude = -122.421873},
				}
			},
			new Region
			{
				Name = "Bellingham Technical College",
				Locations = new List<Location>
				{
					new Location {Latitude = 48.764382, Longitude = -122.508264},
					new Location {Latitude = 48.765103, Longitude = -122.511107},
					new Location {Latitude = 48.766036, Longitude = -122.514240},
					new Location {Latitude = 48.767083, Longitude = -122.516697},
					new Location {Latitude = 48.767670, Longitude = -122.508672},
					new Location {Latitude = 48.766991, Longitude = -122.511633},
				}
			},
			new Region
			{
				Name = "Whatcom Community College",
				Locations = new List<Location>
				{
					new Location {Latitude = 48.794382, Longitude = -122.493322},
					new Location {Latitude = 48.792403, Longitude = -122.492496},
					new Location {Latitude = 48.792332, Longitude = -122.495725},
					new Location {Latitude = 48.794014, Longitude = -122.497141},
					new Location {Latitude = 48.795738, Longitude = -122.493107},
					new Location {Latitude = 48.795893, Longitude = -122.496068},
				}
			},
			new Region
			{
				Name = "Bellingham International Airport",
				Locations = new List<Location>
				{
					new Location {Latitude = 48.798087, Longitude = -122.532905},
					new Location {Latitude = 48.794475, Longitude = -122.530834},
					new Location {Latitude = 48.791885, Longitude = -122.531284},
					new Location {Latitude = 48.789392, Longitude = -122.532679},
					new Location {Latitude = 48.787285, Longitude = -122.527731},
					new Location {Latitude = 48.784324, Longitude = -122.523444},
				}
			},
		};

		//Hardcoded list of pokemon we really don't care about all that much.
		internal static readonly HashSet<PokemonType> ExcludedPokemon = new HashSet<PokemonType>
		{
			PokemonType.Caterpie,
			PokemonType.Metapod,
			PokemonType.Weedle,
			PokemonType.Kakuna,
			PokemonType.Pidgey,
			PokemonType.Pidgeotto,
			PokemonType.Rattata,
			PokemonType.Raticate,
			PokemonType.Spearow,
			PokemonType.Fearow,
			PokemonType.NidoranFemale,
			PokemonType.Nidorina,
			PokemonType.NidoranMale,
			PokemonType.Nidorino,
			PokemonType.Clefary,
			PokemonType.Zubat,
			PokemonType.Golbat,
			PokemonType.Oddish,
			PokemonType.Paras,
			PokemonType.Venonat,
			PokemonType.Psyduck,
			PokemonType.Poliwag,
			PokemonType.Bellsprout,
			PokemonType.Tentacool,
			PokemonType.Seel,
			PokemonType.Shellder,
			PokemonType.Gastly,
			PokemonType.Drowzee,
			PokemonType.Krabby,
			PokemonType.Horsea,
			PokemonType.Goldeen,
			PokemonType.Staryu,
			PokemonType.Magikarp,
			PokemonType.Eevee
		};
	}
}