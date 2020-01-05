using System;
using System.Diagnostics;   //Stopwatch include

public class Lecture
{
	public Lecture()
	{
	}


    public void run()
    {
        //lecture1();
        //lecture2();
        lecture3();
    }
    public void lecture1()
    {
        const int aa = 1;
        int a = int.MaxValue;
        int b = 1;
        int c = 15;
        double f = 123.125;
        Console.WriteLine("{0:0.0}", f);
        Console.WriteLine("|{0}|", aa);
    }
    public void lecture2()
    {
        //lectureSwap();
        //lectureOverloading();
        //lectureRecursive();
        lectureRefOut();
        //lectureRandom();
    }

    public void lecture3()
    {
        //lectureArray();
        //lectureClass();
        lectureStack();
    }

    private int getOperatorPriority(char op)
    {
        if (op == '(' || op == ')') return 0;
        if (op == '-' || op == '+') return 1;
        if (op == '*' || op == '/') return 2;
        return 3;
    }
    private void lectureStack()
    {
        //string s = " 1 + (2 - 3) * 4 + 5 ";
        string s = " 1 + (2 - 3) * 4 + 5 ";
        Console.WriteLine("input => {0}", s);
        MyStack myStack = new MyStack();


        foreach(char selectedChar in s)
        {
            if (selectedChar.Equals(' '))
            {
                continue;
            }
            else if (char.IsNumber(selectedChar))
            {
                Console.Write("{0}", selectedChar);
            }
            else if (selectedChar.Equals(')'))
            {
                int stackCnt = myStack.getCount();
                for(int i=0; i<stackCnt; i++)
                {
                    char popChar = myStack.pop();
                    if (popChar.Equals('('))
                    {
                        break;
                    }
                    Console.Write("{0}", popChar);
                }
                
            }
            else
            {
                
                int stackCnt = myStack.getCount();
                if (stackCnt == 0 || selectedChar.Equals('('))
                {
                    myStack.push(selectedChar);
                }
                else
                {
                    char peekChar = myStack.getPeek();
                    int priorityPeekChar = getOperatorPriority(peekChar);
                    int prioritySelectedChar = getOperatorPriority(selectedChar);
                    //Console.WriteLine("\n peekChar : {0}", getOperatorPriority(selectedChar));
                    //Console.WriteLine("\nselectedChar : {0}", selectedChar);
                    //Console.WriteLine("peekChar : {0}", peekChar);
                    if (priorityPeekChar >= prioritySelectedChar)
                    {
                        //Console.WriteLine("{0} 출력--------", peekChar);
                       // Console.WriteLine("{0} 푸시--------", selectedChar);
                        Console.Write("{0}", myStack.pop());
                        myStack.push(selectedChar);
                    }
                    else
                    {
                        myStack.push(selectedChar);
                    }
                }
            }
        }

        int cnt = myStack.getCount();
        for (int i=0; i< cnt; i++)
        {
            Console.Write("{0}", myStack.pop());
        }
        Console.WriteLine("");

    }

    private void swap(int a, int b)
    {
        int temp = b;
        b = a;
        a = temp;
        Console.WriteLine("swap   :  in a={0}, b={1}", a, b);
    }

    private void mySwap(ref int a, ref int b)
    {
        int temp = b;
        b = a;
        a = temp;
    }

    private void sum(int a, int b, out int result)
    {
        result = a + b;
    }

    private void lectureSwap()
    {
        int a = 1;
        int b = 2;
        Console.WriteLine("before : a={0}, b={1}", a, b);
        swap(a, b);
        Console.WriteLine("swap   : a={0}, b={1}", a, b);
        mySwap(ref a, ref b);
        Console.WriteLine("mySwap : a={0}, b={1}", a, b);
    }

    private int sum(int a, int b)
    {
        Console.WriteLine("int sum");
        return a + b;
    }

    private double sum(double a, double b)
    {
        Console.WriteLine("double sum");
        return a + b;
    }




    private void lectureOverloading()
    {
        double a = 1.1;
        double b = 2.2;
        int c = 3;
        int d = 4;

        double tmpOut;
        bool isDouble = double.TryParse("1.1한글1", out tmpOut);

        Console.WriteLine("isDouble {0} ", isDouble);
        Console.WriteLine("tmpOut {0} ", tmpOut);
        //printf("%f", tmpOut);

        Console.WriteLine("{0} + {1} = {2:0.0}", a, b, sum(a, b));
        Console.WriteLine("{0} + {1} = {2}", c, d, sum(c, d));
        //Console.WriteLine("{0} + {1} = {2:0.0}", a, d, sum(a, double.Parse("1.1한글1") ));
        //Console.WriteLine("{0} + {1} = {2:0.0}", a, d, sum(a, (double)(".1")));
    }

    private int myFactorial(int n)
    {
        //Console.WriteLine("myFactorial : n = {0}", n);
        if (n == 1)
        {
            return 1;
        }
        else
        {
            return n * myFactorial(n - 1);
        }
    }

    private int myFactorialLoop(int n)
    {
        if (n <= 1)
        {
            return 1;
        }
        int result = 1;
        for (int i = n; i > 1; i--)
        {
            result *= i;
            //Console.WriteLine("i = {0} , result = {1}", i, result);
        }
        return result;
    }

    private void lectureRecursive()
    {
        int n = 10;
        Stopwatch sw = new Stopwatch();
        sw.Start();
        Console.WriteLine("myFactorialLoop :  {0}! = {1}", n, myFactorialLoop(n));
        sw.Stop();
        Console.WriteLine(sw.ElapsedMilliseconds.ToString() + "ms");
        sw.Reset();
        sw.Start();
        Console.WriteLine("myFactorial     :  {0}! = {1}", n, myFactorial(n));
        sw.Stop();
        Console.WriteLine(sw.ElapsedMilliseconds.ToString() + "ms");

    }

    private void lectureRefOut()
    {
        int a=1;
        int b=2;
        int result;
        //sum(int a, int b, out int result)
        Console.WriteLine("before : a={0}, b={1}", a, b);
        mySwap(ref a, ref b);
        sum(a, 10, out result);
        Console.WriteLine("mySwap : a={0}, b={1}", a, b);
        Console.WriteLine("sum(a, 10, result) : {0}", result);

    }

    


    private void lectureNoArray()
    {
        int score0 = 3;
        int score1 = 2;
        int score2 = 0;
        int score3 = 0;
        int score4 = 3;
        int totalScore = score0 + score1 + score2 + score3 + score4;
        Console.WriteLine("NoArray totalScore : {0}", totalScore);
    }

    private void lectureWithArray()
    {
        int[] score = { 3, 2, 0, 0, 3 };
        int totalScore = 0;
        for (int i = 0; i < score.Length; i++)
        {
            totalScore += score[i];
        }
        Console.WriteLine("Array totalScore : {0}", totalScore);
    }
    private void lectureArray()
    {
        lectureNoArray();
        lectureWithArray();
    }



    private void lectureClass()
    {
        Person person = new Person();
        person.name = "김양수";
        person.age = 30;
        person.sex = Person.SEX.남자;
        person.talkMyName();
        {
            Person person2 = new Person(person);
            person2.talkMyName();
            GC.SuppressFinalize(person2);
        }

        Person person3 = new Person("아이유", 25, Person.SEX.여자);
        person3.talkMyName();

    }

    private void lectureRandom()
    {
        Random random = new Random();

        int min = 1;
        int max = 999;
        int loopSize = 10;

        for(int i=0; i<loopSize; i++)
        {
            Console.WriteLine("Random[{0}] : {1}", i,random.Next(min, max));
        }

    }


}
