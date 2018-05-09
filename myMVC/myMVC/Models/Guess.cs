using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace myMVC.Models
{
    public class Guess
    {
        public int Guessed;     
        public string msg;
        public int ranNumb;
        public static Random rnd = new Random();
        public List<int> randomList = new List<int>();

        public Guess()
        {
            ranNumb = rnd.Next(1, 100);
            randomList.Add(ranNumb);
        }

        public void NewRandom()
        {
            randomList.Clear();
            randomList.Add(ranNumb);
        }

        public static void Guessing(Guess guess)
        {
            if (guess.randomList.Contains(guess.Guessed))
            {
                guess.msg = $"Congratulations number {guess.Guessed} was the correct answer!";
                guess.NewRandom();
            }
            else if (!guess.randomList.Contains(guess.Guessed))
            {
                guess.msg = $"You guess was wrong. Try Again!";
            }
            //else if (guess.Guessed > guess.ranNumb)
            //{
            //    guess.msg = "Your guess is to high, guess again!";
            //}

        }

    }
}