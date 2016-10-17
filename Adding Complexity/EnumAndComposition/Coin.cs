using System;

namespace EnumAndComposition
{
    public class Coin
    {
        // Declare my CoinFace inside of Coin
        public enum CoinFace { HEADS, TAILS }

        public CoinFace FaceShowing { get; private set; }

        public Coin()
        {
            Toss();
        }

        private static Random _rnd = new Random();

        public void Toss()
        {
            if (_rnd.Next(2) == 0)
                FaceShowing = CoinFace.HEADS;
            else
                FaceShowing = CoinFace.TAILS;
        }
    }
}
