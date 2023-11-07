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
using System.Windows.Shapes;

namespace Labb3Kladd6
{
    /// <summary>
    /// Interaction logic for QuizQuestion.xaml
    /// </summary>
    public partial class Quiz : Window
    {
        private List<Question> questions;
        private int currentQuestionIndex = 0;
        private int score = 0;
        private Random random = new Random();

        public Quiz()
        {
            InitializeComponent();
            InitializeQuiz();
        }

        public void InitializeQuiz()
        {
            questions = new List<Question>();
            questions.Add(new Question
            {
                QuestionText = "In 1768, Captain James Cook set out to explore which ocean?",
                CorrectAnswer = "Pacific Ocean",
                Options = new List<string> { "Pacific Ocean", "Atlantic Ocean", "Indian Ocean", "Arctic Ocean" }
            });

            questions.Add(new Question
            {
                QuestionText = "What is the capital of France?",
                CorrectAnswer = "Paris",
                Options = new List<string> { "London", "Madrid", "Paris", "Rome" }
            });

            questions.Add(new Question
            {
                QuestionText = "Which planet is known as the red planet?",
                CorrectAnswer = "Mars",
                Options = new List<string> { "Venus", "Jupiter", "Mars", "Saturn" }
            });

            questions.Add(new Question
            {
                QuestionText = "Who wrote the novel \"Pride and Prejudice\"?",
                CorrectAnswer = "Jane Austen",
                Options = new List<string> { "Charles Dickens", "Emily Brontë", "Jane Austen", "Leo Tolstoy" }
            });

            questions.Add(new Question
            {
                QuestionText = "What is the chemical symbol for the element gold?\r\n",
                CorrectAnswer = "Au",
                Options = new List<string> { "Go", "Gd", "Au", "Ag" }
            });

            questions.Add(new Question
            {
                QuestionText = "In which year did the Titanic sink?",
                CorrectAnswer = "1912",
                Options = new List<string> { "1912", "1920", "1907", "1931" }
            });

            questions.Add(new Question
            {
                QuestionText = "In which year was the Declaration of Independence of the United States adopted?",
                CorrectAnswer = "1776",
                Options = new List<string> { "1776", "1789", "1804", "1865" }
            });

            questions.Add(new Question
            {
                QuestionText = "What is the largest mammal on Earth?",
                CorrectAnswer = "Blue Whale",
                Options = new List<string> { "African Elephant", "Blue Whale", "Giraffe", "Polar Bear" }
            });

            questions.Add(new Question
            {
                QuestionText = "Who is the author of the novel One Hundred Years of Solitude?",
                CorrectAnswer = "Gabriel Garcia Marquez",
                Options = new List<string> { "Gabriel Garcia Marquez", "Leo Tolstoy", "F. Scott Fitzgerald", "George Orwell" }
            });

            questions.Add(new Question
            {
                QuestionText = "Which gas makes up the majority of the Earth's atmosphere by volume?",
                CorrectAnswer = "Nitrogen",
                Options = new List<string> { "Oxygen", "Nitrogen", "Carbon Dioxide", "Hydrogen" }
            });

            questions.Add(new Question
            {
                QuestionText = "Who is the all-time top scorer in the FIFA World Cup, with 16 goals?",
                CorrectAnswer = "Pele",
                Options = new List<string> { "Lionel Messi", "Cristiano Ronaldo", "Pele", "Diego Maradona" }
            });

            questions.Add(new Question
            {
                QuestionText = "What is the largest planet in our solar system? ",
                CorrectAnswer = "Jupiter",
                Options = new List<string> { "Jupiter", "Saturn", "Uranus", "Neptune", }
            });

            questions.Add(new Question
            {
                QuestionText = "What is the largest desert in Africa, often referred to as the Desert of Deserts?",
                CorrectAnswer = "Sahara Desert",
                Options = new List<string> { "Sahara Desert", "Kalahari Desert", "Namib Desert", "Gobi Desert", }
            });

            questions.Add(new Question
            {
                QuestionText = "The Himalayas, the world's highest mountain range, is a natural boundary between two countries. Which two countries are separated by the Himalayas?",
                CorrectAnswer = "India and China",
                Options = new List<string> { "Thailand and Malaysia", "Iran and Iraq", "Russia and Mongolia", "India and China", }
            });

            questions.Add(new Question
            {
                QuestionText = "Which European city is known as the City of Canals and is famous for its picturesque waterways?",
                CorrectAnswer = "Venice",
                Options = new List<string> { "Paris", "Rome", "Venice", "Amsterdam", }
            });

            questions.Add(new Question
            {
                QuestionText = "Which U.S. state is the largest by land area and is known as the Last Frontier?",
                CorrectAnswer = "Alaska",
                Options = new List<string> { "Texas", "California", "Florida", "Alaska", }
            });

            questions.Add(new Question
            {
                QuestionText = "The Amazon River is the second-longest river in the world. In which South American country is its source located?",
                CorrectAnswer = "Peru",
                Options = new List<string> { "Brazil", "Peru", "Colombia", "Venezuela", }
            });

            questions.Add(new Question
            {
                QuestionText = "What is the largest and most populous city in Australia?",
                CorrectAnswer = "Sydney",
                Options = new List<string> { "Melbourne", "Sydney", "Brisbane", "Perth", }
            });

            questions.Add(new Question
            {
                QuestionText = "Which is the largest landform on the continent of Antarctica, covering about 60% of its surface area?",
                CorrectAnswer = "East Antarctic Plateau",
                Options = new List<string> { "Ross Ice Shelf", "East Antarctic Plateau", "Transantarctic Mountains", "Antarctic Peninsula", }
            });

            questions.Add(new Question
            {
                QuestionText = "In quantum mechanics, what fundamental principle states that certain pairs of physical properties, such as position and momentum, cannot be simultaneously measured with arbitrary precision?",
                CorrectAnswer = "Heisenberg Uncertainty Principle",
                Options = new List<string> { "Planck's Constant", "Schrödinger's Cat", "Heisenberg Uncertainty Principle", "Bohr's Model of the Atom", }
            });

            ShuffleQuestions();
            LoadQuestion(currentQuestionIndex);
        }

        private void ShuffleQuestions()
        {
            int n = questions.Count;
            while (n > 1)
            {
                n--;
                int k = random.Next(n + 1);

                Question value = questions[k];
                questions[k] = questions[n];
                questions[n] = value;
            }
        }

        private void LoadQuestion(int index)
        {
            if (index < questions.Count)
            {
                DataContext = questions[index];
            }
            else
            {
                int questionCount = questions.Count;
                MessageBox.Show($"Quiz completed! Your scored {score} out of {questionCount}.");
                MainWindow restart = new MainWindow();
                restart.Show();
                this.Close();
            }
        }

        private void AnswerButton_Click(object sender, RoutedEventArgs e)
        {
            Button button = (Button)sender;
            string selectedAnswer = button.Content.ToString();
            Question currentQuestion = questions[currentQuestionIndex];

            if (selectedAnswer == currentQuestion.CorrectAnswer)
            {
                score++;
            }

            currentQuestionIndex++;
            LoadQuestion(currentQuestionIndex);
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            
        }
    }
}


