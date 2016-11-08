using System;
using System.Drawing;

namespace SevenKnightsAI.Classes.Mappings
{
    internal static class RaidLobbyPM
    {
        public static readonly PixelMapping AttackedTab = new PixelMapping
        {
            X = 350,
            Y = 91,
            Color = 0,
            Type = MappingType.BUTTON
        };

        public static readonly PixelMapping DefeatedTab = new PixelMapping
        {
            X = 800,
            Y = 91,
            Color = 0,
            Type = MappingType.BUTTON
        };

        public static readonly PixelMapping EnterButton = new PixelMapping
        {
            X = 868,
            Y = 200,
            //Color = 13873749,
            Color = 13478737,
            Type = MappingType.BOTH
        };

        public static readonly PixelMapping EnterButton2 = new PixelMapping
        {
            X = 868,
            Y = 270,
            Color = 13017932,
            //Color = 3151113,
            Type = MappingType.BOTH
        };

        public static readonly PixelMapping EnterButton3 = new PixelMapping
        {
            X = 868,
            Y = 350,
            //Color = 13939542,
            Color = 13873749,
            Type = MappingType.BOTH
        };

        public static readonly PixelMapping EnterButton4 = new PixelMapping
        {
            X = 868,
            Y = 420,
            Color = 10254382,
            //Color = 13610579,
            Type = MappingType.BOTH
        };

        public static readonly PixelMapping GreenIconOnNewTab = new PixelMapping
        {
            X = 214,
            Y = 69,
            Color = 45085,
            Type = MappingType.ANCHOR
        };

        public static readonly PixelMapping ManageParty1Border = new PixelMapping
        {
            X = 46,
            Y = 494,
            Color = 8877126,
            Type = MappingType.ANCHOR
        };

        public static readonly PixelMapping ManageParty1Button = new PixelMapping
        {
            X = 120,
            Y = 500,
            Color = 0,
            Type = MappingType.BUTTON
        };

        public static readonly PixelMapping ManageParty2Border = new PixelMapping
        {
            X = 370,
            Y = 498,
            Color = 6773548,
            Type = MappingType.ANCHOR
        };

        public static readonly PixelMapping ManageParty2Button = new PixelMapping
        {
            X = 323,
            Y = 500,
            Color = 0,
            Type = MappingType.BUTTON
        };

        public static readonly PixelMapping NewTab = new PixelMapping
        {
            X = 550,
            Y = 70,
            Color = 0,
            Type = MappingType.BUTTON
        };

        public static readonly PixelMapping RedIconOnDefeatedTab = new PixelMapping
        {
            X = 718,
            Y = 57,
            Color = 13183490,
            Type = MappingType.ANCHOR
        };

        public static readonly PixelMapping RefreshButton = new PixelMapping
        {
            X = 850,
            Y = 130,
            Color = 0,
            Type = MappingType.BUTTON
        };

        public static readonly int SCROLL_DELTA = 138;

        public static readonly int SCROLL_DOUBLE_DELTA = 275;

        public static readonly PixelMapping ScrollAreaDown = new PixelMapping
        {
            X = 450,
            Y = 430,
            Color = 0,
            Type = MappingType.BUTTON
        };

        public static readonly PixelMapping ScrollAreaUp = new PixelMapping
        {
            X = 450,
            Y = 200,
            Color = 0,
            Type = MappingType.BUTTON
        };

        public static readonly Rectangle DLV1 = new Rectangle
        {
            X = 226,
            Y = 175,
            Height = 22,
            Width = 27
        };

        public static readonly Rectangle DLV2 = new Rectangle
        {
            X = 226,
            Y = 250,
            Height = 22,
            Width = 27
        };

        public static readonly Rectangle DLV3 = new Rectangle
        {
            X = 226,
            Y = 323,
            Height = 22,
            Width = 27
        };

        public static readonly Rectangle DLV4 = new Rectangle
        {
            X = 226,
            Y = 398,
            Height = 22,
            Width = 27
        };

        public static readonly Rectangle Oname1 = new Rectangle
        {
            X = 297,
            Y = 207,
            Height = 24,
            Width = 90
        };

        public static readonly Rectangle Oname2 = new Rectangle
        {
            X = 297,
            Y = 282,
            Height = 24,
            Width = 90
        };

        public static readonly Rectangle Oname3 = new Rectangle
        {
            X = 297,
            Y = 354,
            Height = 24,
            Width = 90
        };

        public static readonly Rectangle Oname4 = new Rectangle
        {
            X = 729,
            Y = 297,
            Height = 24,
            Width = 53
        };
    }
}