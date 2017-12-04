using System;

namespace Server.Factions
{
	public class SerpentsHold : Town
	{
		public SerpentsHold()
		{
			Definition =
				new TownDefinition(
					8,
					0x186A,
                    "Serpents Hold",
                    "Serpents Hold",
					new TextDefinition("SERPENTS HOLD"),
					new TextDefinition( "TOWN STONE FOR SERPENTS HOLD" ),
					new TextDefinition("The Faction Sigil Monolith of Serpents Hold"),
					new TextDefinition("The Faction Town Sigil Monolith of Serpents Hold"),
					new TextDefinition("Faction Town Stone of Serpents Hold"),
					new TextDefinition("Faction Town Sigil of Serpents Hold"),
					new TextDefinition("Corrupted Faction Town Sigil of Serpents Hold"),
					new Point3D( 3024, 3391, 15 ),
					new Point3D( 3017, 3391, 15 ) );
		}
	}
}