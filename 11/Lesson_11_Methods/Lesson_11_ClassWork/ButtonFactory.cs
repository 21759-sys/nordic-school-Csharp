using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson_11_Methods
{
    class ButtonFactory
    {
        public bool PushButtonOnCreate { get; set; }
        public Button CreateButton()
        {
            if (PushButtonOnCreate)
            {
                return new Button(true);
            } 
            else
            {
                return new Button();
            }

        }
    }
}
