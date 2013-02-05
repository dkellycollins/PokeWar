namespace CardLib 
{
    internal class DeckSettings
    {
        public const string ImageExtention = ".jpg";
        public const string BackImgSource = @"pics\CardBack\back" + ImageExtention;
        public const string RedJoker = @"pics\CardFront\Red-Joker" + ImageExtention;
        public const string BlackJoker = @"pics\CardFront\Black-Joker" + ImageExtention;

        public static string FrontImgBaseName(string p)
        {
            return @"pics\CardFront\" + p + ImageExtention;
        }
    }
}
