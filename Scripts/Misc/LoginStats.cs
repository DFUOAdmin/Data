using System;
using Server.Network;

namespace Server.Misc
{
	public class LoginStats
	{
		public static void Initialize()
		{
			// Register our event handler
			EventSink.Login += new LoginEventHandler( EventSink_Login );
		}

		private static void EventSink_Login( LoginEventArgs args )
		{
			int userCount = NetState.Instances.Count;
			int itemCount = World.Items.Count;
			int mobileCount = World.Mobiles.Count;

			Mobile m = args.Mobile;

			m.SendMessage( "Welcome to Dark Factions Pre-Alpha, {0}! There {1} currently {2} user{3} online, with {4} item{5} and {6} mobile{7} in the world.",

				args.Mobile.Name,
				userCount == 1 ? "is" : "are",
				userCount, userCount == 1 ? "" : "s",
				itemCount, itemCount == 1 ? "" : "s",
				mobileCount, mobileCount == 1 ? "" : "s" );
 
            m.SendMessage( "This is currently our Pre-Alpha stage, the server is in a constant state of repair and will be restarted frequently."
                );
            m.SendMessage("");

            m.SendMessage("NOTHING will be saved from this timeperiod. ALL Accounts, Items, and Characters WILL be WIPED!"
                );
		}
	}
}