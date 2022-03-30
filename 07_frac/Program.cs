using System;

namespace _07_frac
{
    class Program
    {
        static void Main(string[] args) {
            Console.WriteLine("demo - print demo for all operations");
            Console.WriteLine("i - start interactive mode");
            string mode = ReadLineWithPrompt("mode: ");
            switch(mode) {
                case "demo":
                    DemoPrint();
                    break;
                case "i":
                    StartInteractive();
                    break;
                default:
                    Console.WriteLine("Wrong input. Must be 'demo' or 'i'");
                    break;
            }
        }

        static void StartInteractive() {
            InteractiveHelp();

            string line;
            while((line = ReadLineWithPrompt("frac_prog> ")) != null) {
                string[] nodes = line.Split(" ");
                if(nodes.Length != 3) {
                    Console.WriteLine("Wrong format. Must be 3 words. 2 spaces. Like this:");
                    Console.WriteLine("number operation number\n");
                    continue;
                }

                string oper = nodes[1];
                Frac f1;
                Frac f2;
                try {
                    f1 = ParseFrac(nodes[0]);
                    f2 = ParseFrac(nodes[2]);
                } catch(Exception e) {
                    Console.WriteLine(e.Message);
                    continue;
                }

                ProcessOper(oper, f1, f2);
            }
        }

        static Frac ParseFrac(string str) {
            string[] nodes = str.Split("/");

            if(nodes.Length > 2) {
                throw new Exception(String.Format(
                            "'{0}' is wrong fraction. Fraction must have only one '/'. Like this:\na/b\n",
                            str));
            }

            if(nodes.Length == 1) {
                int chisl = TryParseInt(nodes[0]);
                return new Frac(chisl, 1);
            }

            int a = TryParseInt(nodes[0]);
            int b = TryParseInt(nodes[1]);

            return new Frac(a, b);
        }

        static void ProcessOper(string oper, Frac f1, Frac f2) {
            Console.WriteLine(f1 + " " + oper + " " + f2);

            string result;
            switch(oper) {
                case "+":
                    result = (f1 + f2).ToString();
                    break;
                case "-":
                    result = (f1 - f2).ToString();
                    break;
                case "*":
                    result = (f1 * f2).ToString();
                    break;
                case "/":
                    result = (f1 / f2).ToString();
                    break;
                case ">":
                    result = (f1 > f2).ToString();
                    break;
                case ">=":
                    result = (f1 >= f2).ToString();
                    break;
                case "<":
                    result = (f1 < f2).ToString();
                    break;
                case "<=":
                    result = (f1 <= f2).ToString();
                    break;
                case "==":
                    result = (f1 == f2).ToString();
                    break;
                case "!=":
                    result = (f1 != f2).ToString();
                    break;
                default:
                    Console.WriteLine("'" + oper + "' is not an operation");
                    return;
            }
            Console.WriteLine("Result: " + result);
        }

        static int TryParseInt(string str) {
            try {
                int a = Convert.ToInt32(str);
                return a;
            } catch (FormatException e) {
                throw new Exception(String.Format("'{0}' must be number", str));
            }
        }

        static string ReadLineWithPrompt(string prompt) {
            Console.Write(prompt);

            return Console.ReadLine();
        }

        static void InteractiveHelp() {
            Console.WriteLine("Format:");
            Console.WriteLine("chisl1/znam1 oper chisl2/znam2");
            Console.WriteLine("Instead of fraction chisl/znam can be just number like this:");
            Console.WriteLine("number1 oper chisl2/znam2");
        }

        static void DemoPrint()
        {
            Frac fr;

            Frac f1 = new Frac(1, 2);
            Frac f2 = new Frac(3, 4);
            int k = 3;

            Console.WriteLine("Multiplication:");
            fr = f1 * f2;
            Console.WriteLine("f1 * f2 = " + f1 + " * " + f2 + " = " + fr);
            fr = f1 * k;
            Console.WriteLine("f1 * k = " + f1 + " * " + k + " = " + fr);
            fr = k * f1;
            Console.WriteLine("k * f1 = " + k + " * " + f1 + " = " + fr);
            Console.WriteLine();

            Console.WriteLine("Sum:");
            fr = f1 + f2;
            Console.WriteLine("f1 + f2 = " + f1 + " + " + f2 + " = " + fr);
            fr = f1 + k;
            Console.WriteLine("f1 + k = " + f1 + " + " + k + " = " + fr);
            fr = k + f1;
            Console.WriteLine("k + f1 = " + k + " + " + f1 + " = " + fr);
            Console.WriteLine();

            Console.WriteLine("Difference:");
            fr = f1 - f2;
            Console.WriteLine("f1 - f2 = " + f1 + " - " + f2 + " = " + fr);
            fr = f1 - k;
            Console.WriteLine("f1 - k = " + f1 + " - " + k + " = " + fr);
            fr = k - f1;
            Console.WriteLine("k - f1 = " + k + " - " + f1 + " = " + fr);
            Console.WriteLine();

            Console.WriteLine("Div:");
            fr = f1 / f2;
            Console.WriteLine("f1 / f2 = " + f1 + " / " + f2 + " = " + fr);
            fr = f1 / k;
            Console.WriteLine("f1 / k = " + f1 + " / " + k + " = " + fr);
            fr = k / f1;
            Console.WriteLine("k / f1 = " + k + " / " + f1 + " = " + fr);
            Console.WriteLine();

            Console.WriteLine("Comparisons:");
            Console.WriteLine("f1 > f2? \n\t" + f1 + " > " + f2 + "? \n\t" + (f1 > f2));
            Console.WriteLine("f1 >= f2? \n\t" + f1 + " >= " + f2 + "? \n\t" + (f1 >= f2));

            Console.WriteLine("f1 < f2? \n\t" + f1 + " < " + f2 + "? \n\t" + (f1 < f2));
            Console.WriteLine("f1 <= f2? \n\t" + f1 + " <= " + f2 + "? \n\t" + (f1 <= f2));

            Console.WriteLine("f1 == f2? \n\t" + f1 + " == " + f2 + "? \n\t" + (f1 == f2));
            Console.WriteLine("f1 != f2? \n\t" + f1 + " != " + f2 + "? \n\t" + (f1 != f2));
            Console.WriteLine();

            Console.WriteLine("Normalize:");
            Frac f_norm = new Frac(64, 1024);
            Console.WriteLine("64/1024 = " + f_norm);
            Console.WriteLine();

            Console.WriteLine("ToString:");
            Frac fa = new Frac(1, 2);
            Console.WriteLine(fa.Chisl + "/" + fa.Znam + " = " + fa);
            fa = new Frac(6, 2);
            Console.WriteLine(fa.Chisl + "/" + fa.Znam + " = " + fa);
            fa = new Frac(3, 2);
            Console.WriteLine(fa.Chisl + "/" + fa.Znam + " = " + fa);

            fa = new Frac(-1, 2);
            Console.WriteLine(fa.Chisl + "/" + fa.Znam + " = " + fa);
            fa = new Frac(-6, 2);
            Console.WriteLine(fa.Chisl + "/" + fa.Znam + " = " + fa);
            fa = new Frac(-3, 2);
            Console.WriteLine(fa.Chisl + "/" + fa.Znam + " = " + fa);
        }
    }
}
