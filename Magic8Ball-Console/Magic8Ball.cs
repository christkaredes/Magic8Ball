using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Magic8Ball_Logic
{

    public class Magic8Ball
    {
        private List<string> _answers;
        private int _index;
        public Magic8Ball()
        {
            _answers = new List<string>();
        }
        
        public void RegularAnswers() // Answers from the Wikipedia article
        {   // Affirmative Answers
            _answers.Add("It is certain.");
            _answers.Add("It is decidedly so.");
            _answers.Add("Without a doubt.");
            _answers.Add("Yes - definitely.");
            _answers.Add("You may rely on it.");
            _answers.Add("As I see it, yes.");
            _answers.Add("Most Likely.");
            _answers.Add("Outlook good.");
            _answers.Add("Yes.");
            _answers.Add("Signs point to yes.");
            // Non-Committal Answers
            _answers.Add("Reply hazy, try again.");
            _answers.Add("Ask again later.");
            _answers.Add("Better not tell you now.");
            _answers.Add("Cannot predict now.");
            _answers.Add("Concentrate and ask again.");
            // Negative Answers
            _answers.Add("Don't count on it.");
            _answers.Add("My reply is no.");
            _answers.Add("My sources say no.");
            _answers.Add("Outlook not so good.");
            _answers.Add("Very doubtful."); 
        }

        public void SeerAnswers() // My custom Azoth answers
        {
            _answers.Add("I do not think so, mortal.");
            _answers.Add("The neighboring spirits say no.");
            _answers.Add("The neighboring spirits say yes.");
            _answers.Add("Do not bother me... I am busy meditating.");
            _answers.Add("You know what? I don't care what you asked. I will make it so.");
            _answers.Add("I do not think so.");
            _answers.Add("You do not want to know the answer to that.");
            _answers.Add("My intuition is saying no.");
            _answers.Add("My intuition is saying yes.");
            _answers.Add("Most certainly.");
            _answers.Add("Even will all my power, I cannot answer that.");
            _answers.Add("The answer to that will take a while to answer. Ask a different one.");
            _answers.Add("I am resting my powers currently. Come back later.");
            _answers.Add("You'll have to ask my brother, Grisor, for that.");
            _answers.Add("STOP ASKING ME QUESTIONS!!!");
            _answers.Add("Don't make me curse you.");
            _answers.Add("Yes...maybe...no.");
            _answers.Add("I'd rather not say. You won't like the answer.");
            _answers.Add("Don't ask any more questions.");
            _answers.Add("Definitely not.");
        }

        public Magic8Ball(List<string> answers)
        {
            _answers = answers;
        }

        public void Shake() // randomly selects a new answer using the Random ( ) class
        {
            Random r = new Random();
            for (int i = 0; i < _answers.Count; i++)
            {
                _index = r.Next(_answers.Count);
            }
        }

        public string GetAnswer() // Returns the answer that was chosen randomly
        {
            return _answers[_index];
        }

        public int AnswerCount // returns a count of how many answers are availible
        {
            get {return _answers.Count;}
        }

        public override string ToString() // returns all the answers in one string, each separated by a new line character
        {
            string allAnswers = string.Join("\n", _answers.ToArray());
            return allAnswers;
        }
    }
}
