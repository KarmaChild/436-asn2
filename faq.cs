using System;
using System.Collections;

namespace faq
{
    public class FAQ
    {
        private Hashtable questions = new Hashtable();

        public bool CreateQuestion(string MyQuestion)
        {
            try
            {
                questions.Add(MyQuestion, "");
                return true;
            }
            catch (ArgumentException e) { return false; }
        }

        public string ListQuestions()
        {
            string keylist = "";

            ICollection keys = questions.Keys;

            foreach (var k in keys)
            {
                keylist = k.ToString() + "\n" + keylist;
            }

            return keylist;
        }
        public string GetComments(string Question)
        {
            return (string)questions[Question];
        }
        public void AddComment(string Question, string Comment)
        {
            questions[Question] = Comment + "\n" + GetComments(Question);
        }



    }
}


