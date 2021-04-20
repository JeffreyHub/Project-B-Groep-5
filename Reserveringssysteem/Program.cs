﻿using System;
using static Reserveringssysteem.Json;

namespace Reserveringssysteem
{
    class Program
    {
        static void Main(string[] args)
        {
            Serialize(new Table[] { new Table("1", 6, new Customer("Oscar"), new Bill(0.00)), new Table("2", 4, new Customer("Arjan"), new Bill(100.0)) }, "tables.json");
            Serialize(new Restaurant[] { new Restaurant(
                "Restaurant De Houten Vork",
                @"Kom gezellig eten!!",
                new string[]{ "Wijnhaven 107", "3011WH", "Rotterdam"},
                new string[]{ "Maandag 14:00 - 22:00",
                "Dinsdag 14:00 - 22:00",
                "Woensdag 14:00 - 22:00",
                "Donderdag 14:00 - 22:00",
                "Vrijdag 14:00 - 00:00",
                "Zaterdag 14:00 - 00:00",
                "Zondag gesloten" },
                new string[]{ "Email : contact@dehoutenvork.nl", "Telefoonnummer : 010-0123463" })}, "restaurants.json");
            var introMenu = new SelectionMenu(new string[4] { "1] Plaats een reservering", "2] Bekijk de menukaart", "3] Informatie over ons", "[Voor Medewerkers]" });
            introMenu.Show();
        }
    }
}
