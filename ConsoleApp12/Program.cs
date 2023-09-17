using System;

// Структура вопроса
struct Question
{
    public string question;
    public string[] options;
    public int correct_answer;
}

class Program
{
    static void Main()
    {
        // Глобально доступный список вопросов
        Question[] questions = {
            new Question {
                question = "В каком году был основан Волгоградский государственный университет ?",
                options = new string[] { "1980", "1991", "1875" },
                correct_answer = 0
            },
            new Question {
                question = "Кто был первым ректором Волгоградского государственного университета?",
                options = new string[] { "Лосев Александр Георгиевич", "Калинина Алла Эдуардовна", "Загорулько Максим Матвеевич" },
                correct_answer = 2
            },
            new Question {
                question = "На сколько студентов рассчитано общежитие ВолГу?",
                options = new string[] { "720", "1085", "2105" },
                correct_answer = 1
            },
            new Question {
                question = "Можно доп баллы?",
                options = new string[] { "ДА!", "обойдешься", "Идешь на экзамен!" },
                correct_answer = 0
            }
        };

        // Функция вывода вопроса и вариантов ответов
        void PrintQuestion(Question q)
        {
            Console.WriteLine(q.question);
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine($"{i + 1}) {q.options[i]}");
            }
        }

        // Функция оценки ответа и вывода результата
        void EvaluateAnswer(Question q, int answer)
        {
            if (answer == q.correct_answer)
            {
                Console.WriteLine("Отлично!");
            }
            else
            {
                Console.WriteLine("Ты отчислен!!!");
            }
        }

        // Цикл по всем вопросам
        int num_questions = questions.Length;
        for (int i = 0; i < num_questions; i++)
        {
            // Вывод вопроса и вариантов ответов
            PrintQuestion(questions[i]);

            // Ввод ответа
            int answer;
            Console.Write("Введи номер ПРАВИЛЬНОГО ответа: ");
            answer = Convert.ToInt32(Console.ReadLine());

            // Оценка ответа и вывод результата
            EvaluateAnswer(questions[i], answer - 1);
        }
    }
}