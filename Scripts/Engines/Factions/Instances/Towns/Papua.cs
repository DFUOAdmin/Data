using System;

namespace Server.Factions
{
	public class Papua : Town
	{
		public Papua()
		{
			Definition =
				new TownDefinition(
					9,
					0x186A,
                    "Papua",
                    "Papua",
					new TextDefinition("PAPUA"),
					new TextDefinition("TOWN STONE FOR PAPUA" ),
					new TextDefinition("The Faction Sigil Monolith of Papua"),
					new TextDefinition("The Faction Town Sigil Monolith of Papua"),
					new TextDefinition("Faction Town Stone of Papua"),
					new TextDefinition("Faction Town Sigil of Papua"),
					new TextDefinition("Corrupted Faction Town Sigil of Papua"),
					new Point3D( 5729, 3210, 1 ),
					new Point3D( 5723, 3203, 1 ) );
		}
	}
}