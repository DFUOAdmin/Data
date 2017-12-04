﻿using System;

namespace Server.Factions
{
    public class BuccaneersDen : Town
    {
        public BuccaneersDen()
        {
            Definition =
                new TownDefinition(
                    12,
                    0x1869,
                    "Buccaneer's Den",
                    "Buccaneer's Den",
                    new TextDefinition("Buccaneer's Den"),
                    new TextDefinition( "Town Stone For Buccaneer's Den"),
                    new TextDefinition("The Faction Sigil Monolith Of Buccaneer's Den"),
                    new TextDefinition("The Faction Town Sigil Monolith Of Buccaneer's Den"),
                    new TextDefinition( "Town Stone Of Bucs"),
                    new TextDefinition("Faction Town Sigil Of Buccaneer's Den"),
                    new TextDefinition( "Corrupted Faction Town Sigil Of Buccaneer's Den"),
                    new Point3D(2753, 2127, 0),
                    new Point3D(2758, 2124, 0));
        }
    }
}