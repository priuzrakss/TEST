using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TEST
{

    internal class Testy
    {
        private String name = "";

        public List<string> Quest_text { get; set; }
        public List<String> Answer_text_1 { get; set; }
        public List<String> Answer_text_2 { get; set; }
        public List<String> Answer_text_3 { get; set; }
        public List<String> Answer_text_4 { get; set; }
        public List<int> is_answ { get; set; }

        public String getName()
        {
            return name;
        }
        public void init()
        {
            Quest_text = new List<string>();
            Answer_text_1 = new List<String>();
            Answer_text_2 = new List<String>();
            Answer_text_3 = new List<String>();
            Answer_text_4 = new List<String>();
            is_answ = new List<int>();
        }
        public void AddQuest(string Quest_text, string Answer_text_1, string Answer_text_2,
            string Answer_text_3, string Answer_text_4, int is_answ)
        {
            this.Quest_text.Add(Quest_text.ToString());
            this.Answer_text_1.Add(Answer_text_1);
            this.Answer_text_2.Add(Answer_text_2);
            this.Answer_text_3.Add(Answer_text_3);
            this.Answer_text_4.Add(Answer_text_4);
            this.is_answ.Add(is_answ);
        }
        public void ChangeQuest(int index, string Quest_text, string Answer_text_1,
            string Answer_text_2, string Answer_text_3, string Answer_text_4, int is_answ)
        {
            this.Quest_text[index] = Quest_text;
            this.Answer_text_1[index] = Answer_text_1;
            this.Answer_text_2[index] = Answer_text_2;
            this.Answer_text_3[index] = Answer_text_3;
            this.Answer_text_4[index] = Answer_text_4;
            this.is_answ[index] = is_answ;
        }
        public void DelQuest(int index)
        {
            this.Quest_text[index] = "";
            this.Answer_text_1[index] = "";
            this.Answer_text_2[index] = "";
            this.Answer_text_3[index] = "";
            this.Answer_text_4[index] = "";
            this.is_answ[index] = 0;
        }


        public void setTestName(string name)
        {
            this.name = name;
        }
    }
}
