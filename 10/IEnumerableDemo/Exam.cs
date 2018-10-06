using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IEnumerableDemo
{
    class Exam:IEnumerable
    {
        public Question[] Questions { get; set; }

        public IEnumerator GetEnumerator()
        {
            //return Questions.GetEnumerator();
            return new ExamEnumerator(Questions);

        }
    }

    class ExamEnumerator : IEnumerator
    {
        private Question[] questions;

        public ExamEnumerator(Question[] _questions)
        {
            questions = _questions;
        }

        private int currentIndex = -1;
        public object Current
        {
            get
            {
                return questions[currentIndex];
            }
        }

        public bool MoveNext()
        {


            // currentIndex = (new Random()).Next(0,20) ;

            //currentIndex += 2;
            //int[] randomNumbers = new int[5];
            //Random r = new Random();
            //for (int i = 0; i < randomNumbers.Length; /*i++*/)
            //{
            //    var randomNumber = r.Next(1, 20);
            //    bool isUnique = true;
            //    for (int j = 0; j < i; j++)
            //    {
            //        if (randomNumbers[j] == randomNumber)
            //        {
            //            isUnique = false;
            //            break;
            //        }

            //    }
            //    if (isUnique)
            //        randomNumbers[i++] = randomNumber;
            //}

            //for (int i=0; i<5; i++)
            //{
            //    currentIndex = randomNumbers[i];

            //}


            Random r = new Random();
            currentIndex = r.Next(1, 20);

            return currentIndex<questions.Length;
        }

        public void Reset()
        {
            currentIndex = -1;
        }
    }
}
