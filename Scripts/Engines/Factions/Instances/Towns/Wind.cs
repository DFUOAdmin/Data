using System;

namespace Server.Factions
{
	public class Wind : Town
	{
		public Wind()
		{
			Definition =
				new TownDefinition(
					13,
					0x1870,
					"Wind",
					"Wind",
					new TextDefinition( "WIND" ),
					new TextDefinition( "TOWN STONE FOR WIND" ),
					new TextDefinition( "The Faction Sigil Monolith of Wind" ),
					new TextDefinition( "The Faction Town Sigil Monolith of Wind" ),
					new TextDefinition( "Faction Town Stone of Wind" ),
					new TextDefinition( "Faction Town Sigil of Wind" ),
					new TextDefinition( "Corrupted Faction Town Sigil of Wind" ),
					new Point3D( 5304, 101, 15 ),
					new Point3D( 5298, 102, 15 ) );
		}
	}
}