using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace QuizGame
{


    public partial class startLabel : Form
    {
        private List<Question> questions;
        private int currentQuestionIndex;
        private int score;
        private bool quizFinished;
        private System.Windows.Forms.Timer timer;
        private int totalElapsedTime;
        private int remainingTime;



        public startLabel()
        {
            InitializeComponent();
            InitializeStartScreen();

        }

        private void InitializeQuiz()
        {
            questions = new List<Question>
{
new MultipleChoiceQuestion("Melyik �kori �llam ter�let�n volt Karth�g�?", new List<string> { "�szak-Afrika", "R�mai Birodalom", "Arab F�lsziget", "Mezopot�miai �llamok" }, "�szak-Afrika"),
new MultipleChoiceQuestion("Melyik mai orsz�g ter�let�n tal�lod Karth�g� romjait?", new List<string> { "Tun�zia", "Alb�nia", "G�r�gorsz�g", "N�metorsz�g" }, "Tun�zia"),
new MultipleChoiceQuestion("Melyik �llam ter�let�n �ltek a Kelt�k?", new List<string> { "K�z�p-Eur�pa", "�zsia", "Afrika", "Amerika" }, "K�z�p-Eur�pa"),
new MultipleChoiceQuestion("Melyik sz�zadban volt fontos szerep�k a Kelt�knak?", new List<string> { "Kr.e. 3. sz�zad", "Kr.e. 2. sz�zad", "4. sz�zad", "12. sz�zad" }, "Kr.e. 3. sz�zad"),
new MultipleChoiceQuestion("Melyik mai �llam ter�let�n tal�lhat� a Stonehenge?", new List<string> { "Nagy-Britannia", "USA", "Oroszorsz�g", "Kanada" }, "Nagy-Britannia"),
new MultipleChoiceQuestion("Melyik mai orsz�g ter�let�n van N�ndorfeh�rv�r?", new List<string> { "Szerbia", "Szlov�kia", "Szlov�nia", "Horv�torsz�g" }, "Szerbia"),
new MultipleChoiceQuestion("Melyik �llamhoz tartozott N�ndorfeh�rv�r?", new List<string> { "Magyar Kir�lys�g", "Habsburg Birodalom", "OMM", "Szovjetuni�" }, "Magyar Kir�lys�g"),
new MultipleChoiceQuestion("Mi Boroszl� mai neve?", new List<string> { "Brestov", "Belgr�d", "B�cs", "Moszkva" }, "Brestov"),
new MultipleChoiceQuestion("Melyik mai �llam ter�let�n van Boroszl�?", new List<string> { "Szlov�kia", "Szerbia", "N�metorsz�g", "Oroszorsz�g" }, "Szlov�kia"),
new MultipleChoiceQuestion("Melyik mai �llam (�llamok) ter�let�n �lnek a Maced�nok?", new List<string> { "Maced�nia", "Egyiptom", "M�lta", "Izrael" }, "Maced�nia"),
new MultipleChoiceQuestion("Kb. milyen nagy l�leksz�m�ak a Maced�nok?", new List<string> { "2 milli� f�", "500 ezer f�", "11 milli� f�", "4 milli� f�" }, "2 milli� f�"),
new TrueOrFalseQuestion("Kr. e. 271-ben a Beneventumi csata volt?", true),
new TrueOrFalseQuestion("A Colosseum �p�t�se Kr. u. 80-ban t�rt�nt?", true),
new TrueOrFalseQuestion("P�pa Gergely VII. volt a leghatalmasabb r�mai p�pa?", true),
new TrueOrFalseQuestion("P�pa VI. S�ndor volt a legh�rhedtebb r�mai p�pa?", true),
new TrueOrFalseQuestion("1954-ben Genfi konferencia volt?", true),
new MultipleChoiceQuestion("Kr. e. 271-ben melyik h�res csata t�rt�nt?", new List<string> { "Marathon-i csata", "Salamiszi csata", "Cannae-i csata", "Beneventumi csata" }, "Beneventumi csata"),
new MultipleChoiceQuestion("Mikor �p�lt a Colosseum?", new List<string> { "Kr. e. 312-ben", "Kr. u. 80-ban", "Kr. u. 1453-ban", "Kr. u. 1066-ban" }, "Kr. u. 80-ban"),
new MultipleChoiceQuestion("Ki volt a leghatalmasabb r�mai p�pa?", new List<string> { "P�pa J�nos P�l II.", "P�pa VI. Piusz", "P�pa Gergely VII.", "P�pa Franciscus" }, "P�pa Gergely VII."),
new MultipleChoiceQuestion("Ki volt a legh�rhedtebb r�mai p�pa?", new List<string> { "P�pa VI. Piusz", "P�pa Benedek XVI.", "P�pa J�nos P�l II.", "P�pa VI. S�ndor" }, "P�pa VI. S�ndor"),
new MultipleChoiceQuestion("Ki volt N�polyi Johanna?", new List<string> { "Franciaorsz�g kir�lyn�je ", "Anglia kir�lyn�je", "Olasz renesz�nsz fest�", "N�poly kir�lyn�je" }, "N�poly kir�lyn�je"),
new MultipleChoiceQuestion("Milyen fontos �rtekezlet volt a v�rosban 1954-ben?", new List<string> { "Yalta-i konferencia", "Potsdami konferencia", "Bretton Woods-i", "Genfi konferencia" }, "Genfi konferencia"),
new MultipleChoiceQuestion("A n�polyi kir�lys�g birtokosa a k�z�pkorban?", new List<string> { "Francia kir�lyi csal�dok", "Oszm�n Birodalom", "Velencei K�zt�rsas�g", "Anjou-h�z" }, "Anjou-h�z"),
new MultipleChoiceQuestion("Mi volt a T�zek Tan�csa?", new List<string> { "Leghatalmasabb b�r�s�ga volt", "T�rv�nyhoz� test�lete volt", "Katonai vezet�se volt", "D�zs� test�lete volt" }, "leghatalmasabb b�r�s�ga volt"),
new MultipleChoiceQuestion("Milyen felkel�s volt a v�rosban 1378-ban?", new List<string> { "Medici-csal�d elleni felkel�s", "Parasztfelkel�s", "Ciompi-felkel�s", "Bosny�k felkel�s" }, "Ciompi-felkel�s"),

};



            totalElapsedTime = 0;
            currentQuestionIndex = 0;
            score = 0;
            quizFinished = false;
            questionNumberLabel.Text = "";
            questionNumberLabel.AutoSize = true;
            Controls.Add(questionNumberLabel);


            DisplayQuestion();

           
            timer = new System.Windows.Forms.Timer();
            timer.Interval = 1000; // 1 m�sodperc
            timer.Tick += Timer_Tick;

            // Be�ll�tjuk az indul� id�t
            remainingTime = 5; // 20 m�sodperc
            UpdateTimerLabel();

            // Ind�tjuk az id�z�t�t
            timer.Start();
        }
        private void InitializeStartScreen()
        {
           startButton.Click += StartButton_Click;

            // Elrejtj�k a kv�z elemeket
            questionNumberLabel.Visible = false;
            vGroupBox.Visible = false;
            nextButton.Visible = false;
            scoreLabel.Visible = false;
            retryButton.Visible = false;
            timerLabel.Visible = false;
            timeLabel.Visible = false;
            questionLabel.Visible = false;



        }

        private void StartButton_Click(object sender, EventArgs e)
        {
            InitializeQuiz();
            startButton.Visible = false; // Elrejtj�k a start gombot
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            
            // Cs�kkentj�k a megmaradt id�t
            remainingTime--;
            totalElapsedTime++;
            // Friss�tj�k az UI-t
            UpdateTimerLabel();

            // Ha lej�rt az id�
            if (remainingTime == 0)
            {
                // Meg�ll�tjuk az id�z�t�t
                timer.Stop();

                // K�vetkez� k�rd�s
                currentQuestionIndex++;
                DisplayQuestion();

                // Ind�tjuk az id�z�t�t �jra
                remainingTime = 5; 
                UpdateTimerLabel();
                timer.Start();
            }
        }

        private void DisplayQuestion()
        {
            if (currentQuestionIndex < questions.Count)
            {
                Question currentQuestion = questions[currentQuestionIndex];

                currentQuestion.Display(questionLabel, RadioButton1, RadioButton2, RadioButton3, RadioButton4);

                vGroupBox.Controls.OfType<RadioButton>().ToList().ForEach(radioButton => radioButton.Checked = false);
                labels.Visible = false;
                timerLabel.Visible = true;
                questionNumberLabel.Visible = true;
                vGroupBox.Visible = true;
                nextButton.Visible = true;
                scoreLabel.Visible = false;
                retryButton.Visible = false;
                timeLabel.Visible = false;
                questionLabel.Visible = true;

                questionNumberLabel.Text = $"K�rd�sek: {currentQuestionIndex + 1}/{questions.Count}";
            }
            else
            {
                timer.Stop();
                labels.Visible = false;
                quizFinished = true;
                questionLabel.Text = "A QV�Z V�GET �RT!";
                questionNumberLabel.Visible = false;
                vGroupBox.Visible = false;
                nextButton.Visible = false;
                scoreLabel.Visible = true;
                retryButton.Visible = true;
                timerLabel.Visible = false;
                timeLabel.Visible = true;
                
                scoreLabel.Text = $"Pontsz�mod: {score}/{questions.Count}";
                timeLabel.Text = $"J�t�kid�: {totalElapsedTime / 60} p {totalElapsedTime % 60} mp";
            }
        }


        private void UpdateTimerLabel()
        {
           
            timerLabel.Text = $"H�tral�v� id�: {remainingTime} mp";
        }


        public abstract class Question
        {
            public string Text { get; }
            public List<string> Choices { get; }
            public string CorrectAnswer { get; }

            protected Question(string text, List<string> choices, string correctAnswer)
            {
                Text = text;
                Choices = choices;
                CorrectAnswer = correctAnswer;
            }

            public abstract void Display(Label questionLabel, RadioButton radioButton1, RadioButton radioButton2, RadioButton radioButton3, RadioButton radioButton4);
        }

        public class MultipleChoiceQuestion : Question
        {
            public MultipleChoiceQuestion(string text, List<string> choices, string correctAnswer)
                : base(text, choices, correctAnswer)
            {
            }

            public override void Display(Label questionLabel, RadioButton radioButton1, RadioButton radioButton2, RadioButton radioButton3, RadioButton radioButton4)
            {
                radioButton1.Visible = true;
                radioButton2.Visible = true;
                radioButton3.Visible = true;
                radioButton4.Visible = true;
                questionLabel.Text = Text;
                radioButton1.Text = Choices[0];
                radioButton2.Text = Choices[1];
                radioButton3.Text = Choices[2];
                radioButton4.Text = Choices[3];
            }
        }

        public class TrueOrFalseQuestion : Question
        {
            public TrueOrFalseQuestion(string text, bool correctAnswer)
                : base(text, new List<string> { "Igaz", "Hamis" }, correctAnswer ? "Igaz" : "Hamis")
            {
            }

            public override void Display(Label questionLabel, RadioButton radioButton1, RadioButton radioButton2, RadioButton radioButton3, RadioButton radioButton4)
            {
                questionLabel.Text = Text;
                radioButton1.Text = Choices[0];
                radioButton3.Text = Choices[1];
                radioButton2.Visible = false;
                radioButton4.Visible = false;
            }
        }


        private void nextButton_Click(object sender, EventArgs e)
        {
            // Check the selected answer
            if (vGroupBox.Controls.OfType<RadioButton>().Any(radioButton => radioButton.Checked))
            {
                Question currentQuestion = questions[currentQuestionIndex];
                RadioButton selectedRadioButton = vGroupBox.Controls.OfType<RadioButton>().FirstOrDefault(radioButton => radioButton.Checked);
                string selectedAnswer = selectedRadioButton.Text;

                if (selectedAnswer == currentQuestion.CorrectAnswer)
                {
                    score++;
                }

                timer.Stop();

                // Ind�tjuk az id�z�t�t �jra
                remainingTime = 5; 
                UpdateTimerLabel();
                timer.Start();

                currentQuestionIndex++;
                DisplayQuestion();
            }
            else
            {
                MessageBox.Show("K�rj�k, v�lasszon egy v�laszt a folytat�s el�tt.", "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void retryButton_Click(object sender, EventArgs e)
        {

            InitializeQuiz();

        }


    }
}


