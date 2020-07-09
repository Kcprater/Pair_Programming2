using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pair_Console_Take2
{
    public class Player
    {
        public int GuessPlayer { get; set; }
        public int WordPlayer { get; set; }
        public int Player1Score { get; set; }
        public int Player2Score { get; set; }

        public Player()
        {

        }

        public Player(int guessplayer, int wordplayer, int player1score, int player2score)
        {
            GuessPlayer = guessplayer;
            WordPlayer = wordplayer;
            Player1Score = player1score;
            Player2Score = player2score;
        }
    }
}
