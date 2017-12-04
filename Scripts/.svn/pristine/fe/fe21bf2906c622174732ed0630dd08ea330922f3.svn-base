#region References
using System;

using Server.Network;
#endregion

namespace Server
{
	public class CurrentExpansion
	{
		public const Expansion Expansion = Server.Expansion.UOR;

		[CallPriority(Int32.MinValue)]
		public static void Configure()
		{
			Core.Expansion = Expansion.UOR;

			ObjectPropertyList.Enabled = false;

			if (ObjectPropertyList.Enabled)
			{
				PacketHandlers.SingleClickProps = true; // single click for everything is overriden to check object property list

				CharacterList.AdditionalFlags |= CharacterListFlags.ExpansionUOR;
			}

			Mobile.GuildClickMessage = !ObjectPropertyList.Enabled;
			Mobile.AsciiClickMessage = !ObjectPropertyList.Enabled;
			Mobile.OldPropertyTitles = !ObjectPropertyList.Enabled;

			Mobile.InsuranceEnabled = Core.AOS;
			Mobile.VisibleDamageType = VisibleDamageType.Related;

			if (Core.AOS)
			{
				AOS.DisableStatInfluences();

				Mobile.ActionDelay = TimeSpan.FromSeconds(0.5);
			}
		}
	}
}