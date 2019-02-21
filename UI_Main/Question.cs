using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UI_Main
{
    class Question
    {
        String Title;
        List<String> ChoiceContent;
        
        public Question()
        {
           
        }

        public Question(String title, List<String> choice)
        {
            this.Title = title;
            this.ChoiceContent = choice;
        }
    }
}
