////using System.Text;
//Console.WriteLine("[FIRST TASK]");
//Console.Write("Hello! Type your name, please: ");//first task
//string name = Console.ReadLine();
//Console.WriteLine($"Nice to meet you {name} !");
//Console.WriteLine($"Приятно познакомиться, {name}! ");

////second task
////write to file
//Console.WriteLine("[SECOND TASK]");
//string fileName = "example.txt";
//string addText = "It is my text ";

//using (StreamWriter sw = new StreamWriter(fileName))
//{
//    sw.Write(addText);
//}
////read from file
//string getText = "";
//using (StreamReader sr = new StreamReader(fileName))
//{
//    while ((getText = sr.ReadLine()) != null)
//    {
//        Console.WriteLine(getText);
//    }
//}

//add text

//Console.Write("Type something: ");

//string consoleText = Console.ReadLine();

//Console.Write("Type something, again: ");
//string consoleText2 = Console.ReadLine();


//using (StreamWriter sw = new StreamWriter(fileName, true))
//{
//    sw.Write($"{consoleText} {consoleText2}");
//}

//Console.Write("Your text: ");
//string NewText;

//using (StreamReader sr = new StreamReader(fileName))
//{
//    while ((NewText = sr.ReadLine()) != null)
//    {
//        Console.WriteLine(NewText);
//    }
//}


////task3

//Console.WriteLine("[THIRD TASK]");
//Console.Write("Hello! Type byte-text: ");
//string byteText = Console.ReadLine();
//string path = "NewText.txt";

//using (FileStream fstream = new FileStream(path, FileMode.OpenOrCreate))
//{
//    byte[] buffer = Encoding.Default.GetBytes(byteText);
//    fstream.Write(buffer, 0, buffer.Length);
//    Console.WriteLine("Text was written");
//}

//Console.WriteLine("[FIRST TASK]");
/*
Console.WriteLine("[FIRST TASK]");
Random randomGenerator = new Random();
int light = randomGenerator.Next(2);


if (light == 1)
{
    Console.WriteLine("light ON");
}
else
{
    Console.WriteLine("light OFF");
}

Console.WriteLine("Turn the light: Yes-true/No-false");
string decision = Console.ReadLine();
bool decisionConvert;
while(!bool.TryParse(decision,out decisionConvert))
{
    Console.Write($"{decision} is not 1 or 0, try again!");
    decision = Console.ReadLine();
}

if (!decisionConvert)
{
    Console.WriteLine("You decided do nothing, good job!");
    return;
}
else

if (light == 1)
{
    Console.WriteLine("You turned off the light");
    light = 0;

}
else 
{
    Console.WriteLine("You turned on the light");
    light = 1;
}*/


//using System;
//using System.Drawing;

//Console.WriteLine("[SECOND TASK/ MOVING ON MAP]");
//Console.Title = "My_first_pic";
//Console.ForegroundColor = ConsoleColor.Yellow;
////


//Console.WriteLine(Console.LargestWindowHeight);
//Console.WriteLine(Console.LargestWindowWidth);
/*
int height = 20;
int width = 20;

char[,] array = new char[20, 20];


for (int i = 1; i < 10; i++)
{
    Console.SetCursorPosition(1, 2);
    Console.CursorLeft = width;
    Console.Write('*');
    array[i, 1] = '*';
    width -=2;
}
int width2 = 20;
for (int i = 1; i < 10; i++)
{
    Console.SetCursorPosition(4, i + 2);
    Console.WriteLine('*');
    array[]
    Console.SetCursorPosition(width2, i + 2);
    Console.WriteLine('*');
}

for (int i = 0; i < 9; i++)
{
    Console.SetCursorPosition(1, 12);
    Console.CursorLeft = height;
    Console.Write('*');
    height -= 2;
}

Console.ForegroundColor = ConsoleColor.Blue;
Console.SetCursorPosition(12, 7);
Console.Write('♥');

Console.SetCursorPosition(1, 13);
Console.WriteLine($"Player coords: X is 12 & Y is 7");
Console.Write("Take direction{AWSD}: ");
int x, y, shift;
var pressedKey = Console.ReadKey(true).KeyChar;
Console.SetCursorPosition(1, 15);
switch (pressedKey)
{
    case 'w':
        Console.WriteLine($"Player coords: X is 12 & Y is 6");
        Console.SetCursorPosition(12, 7);
        Console.Write(" ");
        Console.SetCursorPosition(12, 6);
        Console.Write('♥');
        break;
    case 'a':
        Console.WriteLine($"Player coords: X is 11 & Y is 7");
        Console.SetCursorPosition(12, 7);
        Console.Write(" ");
        Console.SetCursorPosition(11, 7);
        Console.Write('♥');

        break;
    case 's':
        Console.WriteLine($"Player coords: X is 12 & Y is 8");
        Console.SetCursorPosition(12, 7);
        Console.Write(" ");
        Console.SetCursorPosition(12, 8);
        Console.Write('♥');
        break;
    case 'd':
        Console.WriteLine($"Player coords: X is 13 & Y is 7");
        Console.SetCursorPosition(12, 7);
        Console.Write(" ");
        Console.SetCursorPosition(13, 7);
        Console.Write('♥');

        break;
         default:
        Console.Write("Error");
        break;
}
Console.SetCursorPosition(1, 20);
*/


//for (int i = 0; i < 10; i++)
//{
//    for (int j = 0; j < 10; j++)
//    {
//        array[i, j]='0';
//    }
//}

//int i = 0;

//    for (int j = 0; j < 5; j++)
//    {
//        array[i, j] = '*';
//    }
//int i = 9;

//for (int i = 0; i < 10; i++)
//{
//    for (int j = 0; j < 10; j++)
//    {
//        Console.WriteLine(array[i, j]);
//    }

//}



//Console.Write("****************\n" +
//              "*              *\n" +
//              "*              *\n" +
//              "*              *\n" +
//              "*              *\n" +
//              "*              *\n" +
//              "*              *\n" +
//              "*              *\n" +
//              "*              *\n" +
//              "****************");

//int x = 0, y = 0;
//int shiftX = 8, shiftY = 4;
//char[,] array = new char[10, 10];
//Console.SetCursorPosition(x, y);

//for (int i = 0; i < 10; i++)
//{

//    for (int j = 0; j < 10; j++)
//        if ((i == 0) || (i == 9) || (j == 9) || (j == 0))
//        {
//            array[i, j] = '*';
//        }
//        else
//            array[i, j] = ' ';

//}


//for (int i = 0; i < 10; i++)
//{

//    for (int j = 0; j < 10; j++)
//    {
//        Console.Write(array[i, j]);
//    }
//    Console.WriteLine();
//}



//Console.SetCursorPosition(x + shiftX, y + shiftY);
//Console.Write("@");

//ConsoleKeyInfo move = Console.ReadKey(true);

//Console.SetCursorPosition(x + shiftX, y + shiftY);
//Console.Write(" ");
//switch (move.Key)
//{
//    case ConsoleKey.W:
//        y--;
//        break;
//    case ConsoleKey.A:
//        x--;
//        break;
//    case ConsoleKey.S:
//        y++;
//        break;
//    case ConsoleKey.D:
//        x++;
//        break;
//}
//Console.SetCursorPosition(x + shiftX, y + shiftY);
//Console.Write("@");
//Console.SetCursorPosition(15, 15);
//Console.SetCursorPosition(0, 0);
//for (int i = 0; i < 10; i++)
//{
//    for (int j = 0; j < 15; j++)
//    {
//        array[i, j] = Console.ReadLine();
//    }
//}

//using System;
//using System.Collections.Generic;

namespace FirstProject
{
    internal class Program
    {
        //enum Authorization
        //{
        //    Registration = 1,
        //    Authorization = 2,
        //    Generation = 3,
        //    Fight = 4,
        //    Exit = 5
        //}
        //static void Main(string[] args)
        //{
        //    Console.WriteLine($"Your choise: ");
        //    Console.WriteLine($"Push {(int)Authorization.Registration} to make Registration");
        //    Console.WriteLine($"Push {(int)Authorization.Authorization} to make Authorization");
        //    Console.WriteLine($"Push {(int)Authorization.Generation} to make Generation");
        //    Console.WriteLine($"Push {(int)Authorization.Fight} to make Fight");
        //    Console.WriteLine($"Push {(int)Authorization.Exit} to make Exit");
        //    string decision = Console.ReadLine();

        //    Authorization call = (Authorization)int.Parse(decision);
        //    Console.WriteLine($"Your decision is: {call}");

        //  }
        enum purson
        {
            Head = 1,
            Body = 2,
            Legs = 3
        }
        static void Main(string[] args)
        {
            Console.WriteLine($"Put 10 numbers");
            List<int> myNum = new List<int>();
            for (int i = 0; i < 10; i++)
            {
                string vect = Console.ReadLine();
                int numb;
                int.TryParse(vect, out numb);
                myNum.Add(numb);
            }
            int value = myNum[1];

            for (int i = 1; i < myNum.Count; i++)
            {
                if (value < myNum[i])
                    value = myNum[i];
            }
            Console.WriteLine($"MAX:{value}");
        


        int countP = 0;
        int countC = 0;
        Console.WriteLine($"=================\nTotal count:\nyou:{countP}|computer:{countC}\n=================\n");
do
{
    Console.WriteLine($"Push {(int)purson.Head} to fight HEAD");
    Console.WriteLine($"Push {(int)purson.Body} to fight BODY");
    Console.WriteLine($"Push {(int)purson.Legs} to fight LEGS");
    Console.WriteLine($"Your choise: ");
    string fight = Console.ReadLine();
        int kickPur = (int)(purson)int.Parse(fight);
        Console.WriteLine($"Push {(int)purson.Head} to defense HEAD");
    Console.WriteLine($"Push {(int)purson.Body} to defense BODY");
    Console.WriteLine($"Push {(int)purson.Legs} to defense LEGS");
    Console.WriteLine($"Your defense: ");
    string defense = Console.ReadLine();
        Random random = new Random();
        int protectionPur = (int)(purson)int.Parse(defense);
        int kickComp = random.Next(1, 3);
        int protectionComp = random.Next(1, 3);
    //Console.WriteLine($"++++++\nComputer\nkick {kickComp} defense {protectionComp}");

    if (kickPur == protectionComp)

        Console.WriteLine($"Computer protected");
    else
    {
        Console.WriteLine($"You pushed computer");
        countP++;
    }

    if (kickComp == protectionPur)
        Console.WriteLine($"You protected");
    else
    {
        Console.WriteLine($"Computer pushed you");
        countC++;
    }
Console.WriteLine($"=================\nTotal count:\nyou:{countP}|computer:{countC}\n=================\n");

bool condition1 = !(countP == 5 || countC == 5);
bool condition2 = Math.Abs(countP - countC) > 2;
}
while ((countP < 5 && countC < 5) || (Math.Abs(countP - countC) < 2)) ;
if (countP > countC)
    Console.WriteLine($"++++++++++\nYou win\n++++++++++");
else
    Console.WriteLine($"++++++++++\nComputer wins\n++++++++++");

    }
}
}




