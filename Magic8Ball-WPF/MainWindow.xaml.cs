using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Magic8Ball_Logic;

namespace Magic8Ball_WPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void BtnGetAnswer_Click(object sender, RoutedEventArgs e)
        {
            Magic8Ball Toy = new Magic8Ball(); // The 8 Ball class is called
            Toy.RegularAnswers(); // Wikipedia answers are selected
            Toy.Shake(); // Randomly selects an answer

            string _question = txtQuestion.Text; // Question from the user is saved here
            string _answer = Toy.GetAnswer(); // Returns the randomly selected answer

            string enterQuestion = "Please fill in the question box.";
            string gettingAnswer = "Getting your answer...";

            if(txtQuestion.Text.Length == 0) // Prevents user from submitting an empty box
            {
                MessageBox.Show(enterQuestion);
            }
            else
            {
                MessageBox.Show(gettingAnswer); // Feedback to let user know that the quesiton is being answered
                txtAnswer.Text = ("The answer to your question " + "'" + _question + "'" + " is " + "'" + _answer + "'");
            }
        }
    }
}