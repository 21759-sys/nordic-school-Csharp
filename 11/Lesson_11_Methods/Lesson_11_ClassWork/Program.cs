using System;

namespace Lesson_11_Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            Human human_1 = new Human("default_name", 00);
            Human human_2 = new Human();

            human_1.UpdateProperties("John", 36);
            human_1.UpdateProperties("John", "Ireland", 36);
            /////////////////////////////////

            // Создаватель кнопок Button Factory
            ButtonFactory buttonFactory = new ButtonFactory();

            Button[] buttons = new Button[10];
            for (int i = 0; i < buttons.Length; i++)
            {
                buttonFactory.PushButtonOnCreate = i < 5;
                buttons[i] = buttonFactory.CreateButton();
            }
        }
    }
}
