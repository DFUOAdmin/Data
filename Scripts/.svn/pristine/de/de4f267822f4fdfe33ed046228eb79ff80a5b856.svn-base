using System;
using Server;
using Server.Items;
using Server.Mobiles;

namespace Xanthos.Evo
{
    public class DreadHornEvoDust : BaseEvoDust
	{
		[Constructable]
		public DreadHornEvoDust() : this( 1 )
		{
		}

		[Constructable]
		public DreadHornEvoDust( int amount ) : base( amount )
		{
			Amount = amount;
			Name = "Dread Horn Dust";
			Hue = 1153;
		}

		public DreadHornEvoDust( Serial serial ) : base ( serial )
		{
		}

		public override BaseEvoDust NewDust()
		{
            return new DreadHornEvoDust ();
		}

		public override void Serialize( GenericWriter writer )
		{
			base.Serialize( writer );
			writer.Write( (int) 0 );
		}

		public override void Deserialize( GenericReader reader )
		{
			base.Deserialize( reader );
			int version = reader.ReadInt();
		}
	}
}