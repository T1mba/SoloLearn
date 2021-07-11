using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            string Name;
            Console.WriteLine("What is your Name sir");
            Name = Console.ReadLine();
            Console.WriteLine("Hello {0}", Name);

            Console.WriteLine("Введите возраст: ");
            int Age = Convert.ToInt32(Console.ReadLine());
            int Truage = 18;
            if (Age < Truage)
                Console.WriteLine("Доступ запрещен, так как вам нет 18");
            else
                Console.WriteLine("Доступ разрешён");
           
            string Name;
           int Age;
           string Secondname;
           Console.WriteLine("Введите имя: ");
           Name = Console.ReadLine();
           Console.WriteLine("Введите возраст: ");
           Age = Convert.ToInt32(Console.ReadLine());
           Console.WriteLine("Введите почту: ");
           Secondname = Console.ReadLine();

           Console.WriteLine("Name: " + Name );
           Console.WriteLine("Age: " + Age);
           if (Secondname.Length < 5 || Secondname.Contains("@") || Secondname.Contains("."))
           {
               Console.WriteLine("Почта: " + Secondname);
           }
           else
           {
               Console.WriteLine("Введена неверная почта! ");
           }

           
            const double pi = 3.14;
            Console.WriteLine("Введите радиус: ");
            double radius = Convert.ToDouble(Console.ReadLine());
            radius = Math.Pow(radius, 2);
            double x = pi * radius;
            Console.WriteLine("Площадь круга равна = " + x);
           
           
            int Vozrast;
            Console.WriteLine("Введите возраст");
            Vozrast = Convert.ToInt32(Console.ReadLine());
            if (Vozrast >= 18)
                Console.WriteLine("Вы совершеннолетний");
            else
            {
                Console.WriteLine("Вы не совершеннолетний");
            }
            
            
            int a = 8;
            int b = ++a;
            if (a > 5)
                b -= 3;
            else
                b = 9;
            Console.WriteLine(b);
            
            
            int num = 3;
            switch (num)
            {
                case 1:
                    Console.WriteLine("one");
                    break;
                case 2:
                    Console.WriteLine("two");
                    break;
                case 3:
                    Console.WriteLine("three");
                    break;
            }
           
           
            int age = 70;
            switch(age)
            {
                case 16:
                Console.WriteLine("Too young");
                break;
                case 42:
                    Console.WriteLine("Adult");
                    break;
                case 70:
                    Console.WriteLine("Senior");
                        break;
                default:
                    Console.WriteLine("The default case");
                    break;
           
            }
            
            int Srok = 18;
            switch(Srok)
            {
                case 20:
                    Console.WriteLine("Вы опоздали");
                    break;
                case 10:
                    Console.WriteLine("Вы не успели");
                    break;
                case 25:
                    Console.WriteLine("Вы успели точно в срок");
                    break;
                default:
                    Console.WriteLine("Вы не приступали к работе");
                    break;
                    
            }
           
            
            int sum = 15;
            while (sum++ <50)
            {
                Console.WriteLine(sum);
                    
            }
                
            for (int x = 10; x < 15; x++)
            {
                Console.WriteLine("Значение x: {0}", x);
            }
             
            int x = 10;
            for(;x>0;)
            {
                Console.WriteLine("Значение x: {0}", x);
                x += 3;
            }
           
            int x = 10;
                while(x>0)
            {
                Console.WriteLine(x);
                x-=2;
            }
            
            int x = 10;
            switch(x)
            {
                case 15:
                    
                        Console.WriteLine("Больше на 5");
                        break;
                    
                case 20:
                    
                        Console.WriteLine("Больше на 10");
                        break;
                    
                case 1:
                    Console.WriteLine("Не подходит");
                        break;
                default:
                    Console.WriteLine("Нет подходящих вариантов");
                    break;
                    
            
            for(int x = 20; x<=40; x+=2)
            {
                Console.WriteLine(x);
            }
            
            int a = 0;
            do
            {
                Console.WriteLine(a);
                a++;
            }
            while (a < 5);
           
            int x = 45;
            do
            {
                Console.WriteLine(x);
                x++;
            }
            while (x < 10);
         
            string name;
            int age;
            Console.WriteLine("Введите ваше имя");
           
            name = Console.ReadLine();
            Console.WriteLine("Введите ваш возраст");
            age = Convert.ToInt32(Console.ReadLine());
            if (age <= 18)
            {
                Console.WriteLine("Вы совершеннолетний");
                Console.WriteLine("Ваше имя: " + name + "\nВаш возраст: " + age );
            }
            else
            {
                Console.WriteLine("Отказано в доступе");
            }
               
            int num = 0;
            while(num <20)
            {
                if (num == 19)
                    break;
                Console.WriteLine(num);
                    num++;
            }
           
            for(int i = 0; i<100; i++)
            {
                if (i % 2 != 0)
                    continue;
                Console.WriteLine(i);
            }
              

            int age;
            int grade;
            int money;
            Console.WriteLine("Введите возраст");
            age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите оценку");
            grade = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Количество денег");
            money = Convert.ToInt32(Console.ReadLine());
            if (age > 18 || grade > 2 || money > 200)
            {
                Console.WriteLine("Все прошло успешно" + "\nВозраст подходит, так как больше или равен 18" + age +"\nОценка удовлетворительна, так как больше двух" + grade + "\nПервоначальный взнос внесён" + money);
            }
            else
            {
                Console.WriteLine("Зачёт не сдан");
            }

            

            int age;
            int score;
            Console.WriteLine("Enter  age: ");
            age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter the number of points: ");
            score = Convert.ToInt32(Console.ReadLine());
            if (age >= 18 || score >= 50)
            {
                Console.WriteLine("Welcome");
                Console.WriteLine("Age = " + age + "\nscore = " + score);
            }
            else
            {
                Console.WriteLine("Access id denied");
            }
            
            int age = 18;
            if (!(age >= 16))
            {
                Console.WriteLine("Your age is less than 16");
            }
            else
            {
                Console.WriteLine("Did not work");
            }
            
            int age;
            Console.WriteLine("Введите возраст: ");
            age = Convert.ToInt32(Console.ReadLine());
            string message;
            message = (age >= 18) ? "Welcome" : "sorry";
            Console.WriteLine(message);
            
            do
            {
                Console.Write("x = ");
               
                string str = Console.ReadLine();
                if(str == "Exit")
                 break;

                int x = Convert.ToInt32(str);
                Console.Write("y = ");
                int y = Convert.ToInt32(Console.ReadLine());

                int sum = x + y;
                Console.WriteLine("Result : {0}", sum);
            }
            while (true);
            
            int x = 4; int y = 9;
            x = (y % x != 0) ? y / x : y;
          
            int number = Convert.ToInt32(Console.ReadLine());
            if (number % 3)
                number == *
           
            int Age;
            string Email;
            string Name;
            Console.WriteLine("Input Age: ");
            Age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Input Email: ");
            Email = Console.ReadLine();
            Console.WriteLine("Input Name: ");
            Name = Console.ReadLine();
            if (Age < 18)
            {
                Console.WriteLine("No entry");
            }
            else
            {
                Console.WriteLine("Access is allowed"); 
            }
            if (Email.Contains("@") || Email.Length < 5 || Email.Contains("."))
            {

            }
            
               
            else
            {
                Console.WriteLine("Incorrect mail format");
            }
    
              */

        
            

        }

    }
}

