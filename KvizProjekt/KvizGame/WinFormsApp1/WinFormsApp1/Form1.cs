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
new MultipleChoiceQuestion("Melyik ókori állam területén volt Karthágó?", new List<string> { "Észak-Afrika", "Római Birodalom", "Arab Félsziget", "Mezopotámiai államok" }, "Észak-Afrika"),
new MultipleChoiceQuestion("Melyik mai ország területén találod Karthágó romjait?", new List<string> { "Tunézia", "Albánia", "Görögország", "Németország" }, "Tunézia"),
new MultipleChoiceQuestion("Melyik állam területén éltek a Kelták?", new List<string> { "Közép-Európa", "Ázsia", "Afrika", "Amerika" }, "Közép-Európa"),
new MultipleChoiceQuestion("Melyik században volt fontos szerepük a Keltáknak?", new List<string> { "Kr.e. 3. század", "Kr.e. 2. század", "4. század", "12. század" }, "Kr.e. 3. század"),
new MultipleChoiceQuestion("Melyik mai állam területén található a Stonehenge?", new List<string> { "Nagy-Britannia", "USA", "Oroszország", "Kanada" }, "Nagy-Britannia"),
new MultipleChoiceQuestion("Melyik mai ország területén van Nándorfehérvár?", new List<string> { "Szerbia", "Szlovákia", "Szlovénia", "Horvátország" }, "Szerbia"),
new MultipleChoiceQuestion("Melyik államhoz tartozott Nándorfehérvár?", new List<string> { "Magyar Királyság", "Habsburg Birodalom", "OMM", "Szovjetunió" }, "Magyar Királyság"),
new MultipleChoiceQuestion("Mi Boroszló mai neve?", new List<string> { "Brestov", "Belgrád", "Bécs", "Moszkva" }, "Brestov"),
new MultipleChoiceQuestion("Melyik mai állam területén van Boroszló?", new List<string> { "Szlovákia", "Szerbia", "Németország", "Oroszország" }, "Szlovákia"),
new MultipleChoiceQuestion("Melyik mai állam (államok) területén élnek a Macedónok?", new List<string> { "Macedónia", "Egyiptom", "Málta", "Izrael" }, "Macedónia"),
new MultipleChoiceQuestion("Kb. milyen nagy lélekszámúak a Macedónok?", new List<string> { "2 millió fõ", "500 ezer fõ", "11 millió fõ", "4 millió fõ" }, "2 millió fõ"),
new TrueOrFalseQuestion("Kr. e. 271-ben a Beneventumi csata volt?", true),
new TrueOrFalseQuestion("A Colosseum építése Kr. u. 80-ban történt?", true),
new TrueOrFalseQuestion("Pápa Gergely VII. volt a leghatalmasabb római pápa?", true),
new TrueOrFalseQuestion("Pápa VI. Sándor volt a leghírhedtebb római pápa?", true),
new TrueOrFalseQuestion("1954-ben Genfi konferencia volt?", true),
new MultipleChoiceQuestion("Kr. e. 271-ben melyik híres csata történt?", new List<string> { "Marathon-i csata", "Salamiszi csata", "Cannae-i csata", "Beneventumi csata" }, "Beneventumi csata"),
new MultipleChoiceQuestion("Mikor épült a Colosseum?", new List<string> { "Kr. e. 312-ben", "Kr. u. 80-ban", "Kr. u. 1453-ban", "Kr. u. 1066-ban" }, "Kr. u. 80-ban"),
new MultipleChoiceQuestion("Ki volt a leghatalmasabb római pápa?", new List<string> { "Pápa János Pál II.", "Pápa VI. Piusz", "Pápa Gergely VII.", "Pápa Franciscus" }, "Pápa Gergely VII."),
new MultipleChoiceQuestion("Ki volt a leghírhedtebb római pápa?", new List<string> { "Pápa VI. Piusz", "Pápa Benedek XVI.", "Pápa János Pál II.", "Pápa VI. Sándor" }, "Pápa VI. Sándor"),
new MultipleChoiceQuestion("Ki volt Nápolyi Johanna?", new List<string> { "Franciaország királynõje ", "Anglia királynõje", "Olasz reneszánsz festõ", "Nápoly királynõje" }, "Nápoly királynõje"),
new MultipleChoiceQuestion("Milyen fontos értekezlet volt a városban 1954-ben?", new List<string> { "Yalta-i konferencia", "Potsdami konferencia", "Bretton Woods-i", "Genfi konferencia" }, "Genfi konferencia"),
new MultipleChoiceQuestion("A nápolyi királyság birtokosa a középkorban?", new List<string> { "Francia királyi családok", "Oszmán Birodalom", "Velencei Köztársaság", "Anjou-ház" }, "Anjou-ház"),
new MultipleChoiceQuestion("Mi volt a Tízek Tanácsa?", new List<string> { "Leghatalmasabb bírósága volt", "Törvényhozó testülete volt", "Katonai vezetése volt", "Dózsé testülete volt" }, "leghatalmasabb bírósága volt"),
new MultipleChoiceQuestion("Milyen felkelés volt a városban 1378-ban?", new List<string> { "Medici-család elleni felkelés", "Parasztfelkelés", "Ciompi-felkelés", "Bosnyák felkelés" }, "Ciompi-felkelés"),

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
            timer.Interval = 1000; // 1 másodperc
            timer.Tick += Timer_Tick;

            // Beállítjuk az induló idõt
            remainingTime = 5; // 20 másodperc
            UpdateTimerLabel();

            // Indítjuk az idõzítõt
            timer.Start();
        }
        private void InitializeStartScreen()
        {
           startButton.Click += StartButton_Click;

            // Elrejtjük a kvíz elemeket
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
            startButton.Visible = false; // Elrejtjük a start gombot
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            
            // Csökkentjük a megmaradt idõt
            remainingTime--;
            totalElapsedTime++;
            // Frissítjük az UI-t
            UpdateTimerLabel();

            // Ha lejárt az idõ
            if (remainingTime == 0)
            {
                // Megállítjuk az idõzítõt
                timer.Stop();

                // Következõ kérdés
                currentQuestionIndex++;
                DisplayQuestion();

                // Indítjuk az idõzítõt újra
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

                questionNumberLabel.Text = $"Kérdések: {currentQuestionIndex + 1}/{questions.Count}";
            }
            else
            {
                timer.Stop();
                labels.Visible = false;
                quizFinished = true;
                questionLabel.Text = "A QVÍZ VÉGET ÉRT!";
                questionNumberLabel.Visible = false;
                vGroupBox.Visible = false;
                nextButton.Visible = false;
                scoreLabel.Visible = true;
                retryButton.Visible = true;
                timerLabel.Visible = false;
                timeLabel.Visible = true;
                
                scoreLabel.Text = $"Pontszámod: {score}/{questions.Count}";
                timeLabel.Text = $"Játékidõ: {totalElapsedTime / 60} p {totalElapsedTime % 60} mp";
            }
        }


        private void UpdateTimerLabel()
        {
           
            timerLabel.Text = $"Hátralévõ idõ: {remainingTime} mp";
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

                // Indítjuk az idõzítõt újra
                remainingTime = 5; 
                UpdateTimerLabel();
                timer.Start();

                currentQuestionIndex++;
                DisplayQuestion();
            }
            else
            {
                MessageBox.Show("Kérjük, válasszon egy választ a folytatás elõtt.", "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void retryButton_Click(object sender, EventArgs e)
        {

            InitializeQuiz();

        }


    }
}


