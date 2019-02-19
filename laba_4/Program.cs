using System;

namespace laba_4
{
    class Program
    {
        /*enum pol : byte
        {
            Мужской,
            Женский
        }*/
        struct Students
        {
            public string name;
            public string surname;
            public string pol;
            public double ball;
            public byte cource;
            public char flag;

            public Students(string name, string surname, string pol, double ball, byte cource, char flag) {
                this.name = name;
                this.surname = surname;
                this.pol = pol;
                this.cource = cource;
                this.flag = flag;
                this.ball = ball;
            }
        }



        static void Main(string[] args)
        {
            Console.Write("Какое количество студентов записать - ");
            int n = Convert.ToInt32(Console.ReadLine());
            Students[] student = new Students[n];
            for (int i = 0; i < student.Length; i++)
            {
                Console.Write("Введите имя №{0}- ", i);
                string name = Console.ReadLine();
                Console.Write("Введите фамилию №{0}- ", i);
                string surname = Console.ReadLine();
                Console.Write("Введите курс №{0}- ", i);
                byte cource = Convert.ToByte(Console.ReadLine());
                Console.Write("Введите пол №{0}- ", i);
                string pol = Console.ReadLine();
                Console.Write("Введите средний балл №{0}- ", i);
                double ball = Convert.ToDouble(Console.ReadLine());
                char flag = ' ';
                if (student[i].pol == "женский" && student[i].ball == 5)
                {
                    student[i].flag = '*';
                    spez++;
                }
                student[i] = new Students(name,surname,pol,ball,cource,flag);
            }
            
            Console.ReadKey();
        }
    }
}
