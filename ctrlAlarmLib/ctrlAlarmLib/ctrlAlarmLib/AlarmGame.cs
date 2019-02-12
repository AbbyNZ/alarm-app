using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace ctrlAlarmLib
{
    
    public partial class AlarmGame : Form
    {
        private GameController gameController;
        public enum gameOutcome { Win, Lose };

        public AlarmGame()
        {
            InitializeComponent();
            gameController = new GameController(this);
        }

        class Question
        {
            protected string description;
            protected string solution;

            public string getDescription()
            {
                return description;
            }

            public string getSolution()
            {
                return solution;
            }

            public void setDescription(string newDescription)
            {
                description = newDescription;
            }

            public void setSolution(string newSolution)
            {
                solution = newSolution;
            }

            public bool checkAnswer(string answer)
            {
                bool result;
                if (solution == answer)
                {
                    result = true;
                }
                else
                {
                    result = false;
                }
                return result;
            }
        }

        class GameController
        {
            private AlarmGame gameInterface;
            private Question theQuestion;
            private int correct;
            private int incorrect;
            private string question;
            private string solution;
            private StreamReader sr;

            public GameController(AlarmGame newInterface)
            {
                gameInterface = newInterface;
            }

            public void startQuiz()
            {
                sr = new StreamReader("E:\\Berna\\Unitec\\2nd Sem 2016\\ISCG7421 Adv Programme Devt\\Assignment1\\GameQuestions.txt");
                theQuestion = new Question();
                correct = 0;
                incorrect = 0;
            }

            public void processAnswer(string answer)
            {
                if (theQuestion.getSolution().Equals(answer))
                {
                    correct += 1;
                }
                else
                {
                    incorrect += 1;
                }
            }

            public string readQuestion()
            {
                try
                {
                    question = sr.ReadLine();
                    if (question != null)
                    {
                        theQuestion.setDescription(question);
                        solution = sr.ReadLine();
                        theQuestion.setSolution(solution);
                    }
                    else
                    {
                        question = null;
                    }
                }
                catch (IOException)
                {
                    Console.Write("Exception caught while reading the questions file.");
                }
                return question;
            }

            public gameOutcome gameOver()
            {
                gameOutcome result;

                if (correct > incorrect)
                {
                    result = gameOutcome.Win;
                }
                else
                {
                    result = gameOutcome.Lose;
                }
                return result;
            }

            public void reset()
            {
                sr.Close();
            }
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            gameController.startQuiz();
            txtQuestion.Text = gameController.readQuestion();
            btnSubmit.Enabled = true;
            btnStart.Enabled = false;
            txtAnswer.Enabled = true;
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            gameOutcome result;
            string outcome;
            string question;
            gameController.processAnswer(txtAnswer.Text);
            //gameController.processAnswer(cmbAnswer.Text);
            txtQuestion.Text = "";
            txtAnswer.Text = "";
            question = gameController.readQuestion();
            if (question == null)
            {
                result = gameController.gameOver();
                btnSubmit.Enabled = false;
                outcome = Enum.GetName(typeof(gameOutcome), result);
                MessageBox.Show(outcome, "Game Over");
                btnStart.Enabled = true;
                txtAnswer.Enabled = false;
            }
            else
            {
                txtQuestion.Text = question;
            }
        }
        
    }
}
