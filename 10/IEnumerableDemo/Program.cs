﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IEnumerableDemo
{
    class Program
    {
        static void Main(string[] args)
        {

            Exam exam = new Exam();
            exam.Questions = new Question[]
                {
                    new Question() { Text = "1. What's your name?" },
                    new Question() { Text = "2. What's your grade?" },
                    new Question() { Text = "3. Describe Data types?" },
                    new Question() { Text = "4. What does OOP stands for?" },
                    new Question() { Text = "5. What's the difference between Heap and Stack?" },
                    new Question() { Text = "6. What does Nullable mean?" },
                    new Question() { Text = "7. When do you use Break?" },
                    new Question() { Text = "8. What is Inheritance?" },
                    new Question() { Text = "9. Describe OOP" },
                    new Question() { Text = "10. Describe GC" },
                    new Question() { Text = "11. What's the difference between Interface and Abstract Class?" },
                    new Question() { Text = "12. Describe OOP" },
                    new Question() { Text = "13. Describe GC" },
                    new Question() { Text = "14. Describe Function" },
                    new Question() { Text = "15. What's the difference between Value Type and Reference Type?" },
                    new Question() { Text = "16. When do you use Memberhising Method?" },
                    new Question() { Text = "17. Describe Abstract Class" },
                    new Question() { Text = "18. What are different parts of a class?" },
                    new Question() { Text = "19. Describe OOP" },
                    new Question() { Text = "20. Describe GC" },
                };

            foreach (Question question in exam)
            {
                Console.WriteLine(question.Text);
            }

            Console.ReadKey();
        }
    }
}
