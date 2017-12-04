using System;
using Server;
using Server.Items;
using Server.Mobiles;
using Xanthos.Interfaces;

namespace Xanthos.Evo
{
    public class DreadHornEvoEgg : DreadHornEvoBaseEgg
	{
		public override IEvoCreature GetEvoCreature()
		{
            return new DreadHornEvo ( "a Dread Horn hatchling" );
		}

		[Constructable]
        public DreadHornEvoEgg ( ) : base ( )    
		{
            Name = "a dread horn egg";
			HatchDuration = 0.01;		// 15 minutes      1.00 is 1 hours
        }

		public DreadHornEvoEgg( Serial serial ) : base ( serial )
		{
		}

		public override void Serialize( GenericWriter writer )
		{
			base.Serialize( writer );
			writer.Write( (int)0 );
		}

		public override void Deserialize( GenericReader reader )
		{
			base.Deserialize( reader );
			int version = reader.ReadInt();
		}
	}
}