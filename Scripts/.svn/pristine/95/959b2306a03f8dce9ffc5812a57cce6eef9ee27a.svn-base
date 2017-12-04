using System;
using Server;
using Server.Items;
using Server.Mobiles;
using Xanthos.Interfaces;

namespace Xanthos.Evo
{
	[CorpseName( "a dread horn corpse" )]
    public class DreadHornEvo : DreadHornEvoBase , IEvoCreature
	{
		public override BaseEvoSpec GetEvoSpec()
		{
            return DreadHornEvoSpec.Instance;
		}

        public override DreadHornEvoBaseEgg GetEvoEgg ( )
		{
            return new DreadHornEvoEgg ();
		}

		public override bool AddPointsOnDamage { get { return true; } }
		public override bool AddPointsOnMelee { get { return false; } }
        public override Type GetEvoDustType ( ) { return typeof ( DreadHornEvoDust ); }

		public override bool HasBreath{ get{ return true; } }

		public DreadHornEvo( string name ) : base( name, 243, 0x3E94 )
		{
		}

        public DreadHornEvo ( Serial serial ) : base ( serial )
		{
		}

		public override WeaponAbility GetWeaponAbility()	
		{
			return WeaponAbility.Dismount;
		} 

		public override bool SubdueBeforeTame{ get{ return true; } } // Must be beaten into submission
		
		public override int GetAngerSound()
		{
			return 0x4FF;
		}

		public override int GetIdleSound()
		{
			return 0x4FE;
		}

		public override int GetAttackSound()
		{
			return 0x4FD;
		}

		public override int GetHurtSound()
		{
			return 0x500;
		}

		public override int GetDeathSound()
		{
			return 0x4FC;
		}
		
		public override void Serialize(GenericWriter writer)
		{
			base.Serialize(writer);

			writer.Write( (int)0 );			
		}

		public override void Deserialize(GenericReader reader)
		{
			base.Deserialize(reader);

			int version = reader.ReadInt();
		}
	}
}