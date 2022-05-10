using System;
using System.Collections.Generic;
using System.Windows.Forms;

#region
//● As I see it, yes.
//● Most likely.
//● Outlook good.
//● Yes.
//● Signs point to yes.

//● Reply hazy, try again.
//● Ask again later.
//● Better not tell you now.
//● Cannot predict now.
//● Concentrate and ask again.

//● Don't count on it.
//● My reply is no.
//● My sources say no.
//● Outlook not so good.
//● Very doubtful.

#endregion

namespace _8BallGame
{
    public partial class Magic8Ball : Form
    {
        Random random = new Random();   
        List<string> answers = new List<string>();
        public Magic8Ball()
        {
            InitializeComponent();
            answers.Add(" It is certain.");
            answers.Add(" It is decidedly so.");
            answers.Add(" Without a doubt.");
            answers.Add(" Yes definitely.");
            answers.Add(" Signs point to yes.");
            answers.Add(" Concentrate and ask again.");
            answers.Add(" Very doubtful.");
            answers.Add(" Outlook not so good.");
            answers.Add(" Don't count on it.");
            answers.Add(" My reply is no.");
            answers.Add(" My sources say no.");
        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            int index = random.Next(answers.Count);
            answerLabel.Text = answers[index];
        }
    }
}
