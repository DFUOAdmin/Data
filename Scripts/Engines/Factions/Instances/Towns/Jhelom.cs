using System;

namespace Server.Factions
{
	public class Jhelom : Town
	{
		public Jhelom()
		{
			Definition =
				new TownDefinition(
					14,
					0x186D,
                    "Jhelom",
                    "Jhelom",
					new TextDefinition("JHELOM" ),
					new TextDefinition("TOWN STONE FOR JHELOM" ),
					new TextDefinition("The Faction Sigil Monolith of Jhelom"),
					new TextDefinition("The Faction Town Sigil Monolith of Jhelom"),
					new TextDefinition("Faction Town Stone of Jhelom"),
					new TextDefinition("Faction Town Sigil of Jhelom"),
					new TextDefinition("Corrupted Faction Town Sigil of Jhelom"),
					new Point3D( 1423, 3796, 0 ),
					new Point3D( 1418, 3791, 0 ) );
		}
	}
}