using System;

namespace Server.Factions
{
	public class Ocllo : Town
	{
		public Ocllo()
		{
			Definition =
				new TownDefinition(
					10,
					0x186F,
                    "Ocllo",
                    "Ocllo",
					new TextDefinition( "OCLLO" ),
					new TextDefinition( "TOWN STONE FOR OCLLO" ),
					new TextDefinition( "The Faction Sigil Monolith of Ocllo"),
					new TextDefinition( "The Faction Town Sigil Monolith of Ocllo"),
					new TextDefinition( "Faction Town Stone of Ocllo"),
					new TextDefinition( "Faction Town Sigil of Ocllo"),
					new TextDefinition( "Corrupted Faction Town Sigil of Ocllo"),
					new Point3D( 3651, 2517, 0 ),
					new Point3D( 3651, 2511, 0 ) );
		}
	}
}