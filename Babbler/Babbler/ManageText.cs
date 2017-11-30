using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using  System.IO;

namespace Babbler
{
    class ManageText
    {
        string path;
        string userQuestion;
        string userAnswer;

        List<string> sempls = new List<string>();

        bool flag = true;

        public event Action<string> GetStr;

        public ManageText(string path)
        {
            this.path = path;

            try
            {
                sempls.AddRange(File.ReadAllLines(path));
            }
            catch { }

            GetStr += ChatBot_GetStr;

            GetStr("");

        }

        static string Trim(string str)
        {
            char[] chars = ")(:^^-!&*?.,;@#№%".ToCharArray();
            string strA = str;

            for (int i = 0; i < chars.Length; i++)
            {
                strA = strA.Replace(char.ToString(chars[i]), "");
            }
            return strA;
        }

        private string Answer(string qw)
        {
            string ans = string.Empty;

            qw = qw.ToLower();
            qw = Trim(qw);
            string[] baza = File.ReadAllLines("база.txt"); //в этом файле вопросы - ответы

            for (int i = 0; i < sempls.Count; i += 2)
            {
                if (qw == sempls[i])
                {
                    ans = baza[i + 1];
                    break;
                }
            }
            return ans;
        }

        private void Teach()
        {
            sempls.Add(userQuestion);
            sempls.Add(userAnswer);
            File.WriteAllLines(path, sempls.ToArray());
        }

        //генерация ответа
        public void Ans(string qw)
        {
            if (flag)
            {
                qw = qw.ToLower();
                qw = Trim(qw);
                userQuestion = qw;
                string ans = Answer(qw);

                //переход в режим обучения
                if (ans == string.Empty)
                {
                    flag = false;
                    GetStr(" - Я не знаю, что ответить. Ответь сам. \n");

                }
                //режим работы
                else GetStr("- " + ans + " \n ");

            }
            //обучение
            else
            {
                flag = true;
                userAnswer = qw;
                Teach();
                GetStr(" - Я запомнила. \n ");
            }
        }

        void ChatBot_GetStr(string obj) { }
    }
}
