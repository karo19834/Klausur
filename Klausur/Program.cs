using Gremlin.Net.Process.Traversal;
using System;
using static Klausur.Program;

namespace Klausur
{
    class Program
    {
        static void Main(string[] args)
        {

            Quiz quiz = new Quiz();
            Mathequiz mathe = new Mathequiz();
            Start();
        }

        public static void Start()
        {
            Console.WriteLine("Willkommen bei meiner Klausur, für Quiz starten drücke q, für Mathe Aufgaben drückee m, für aussteigen drücke x ");


            Quiz quiz = new Quiz();
            Mathequiz mathe = new Mathequiz();
            string wahl = Console.ReadLine();

            try
            {
                if (wahl == "q")
                {
                    quiz.StelleFrage();
                }
                else if (wahl == "m")
                {
                    mathe.Stellefrage();
                }
                if (wahl == "x")
                {
                    Environment.Exit(0);
                }
            }
            catch (System.IO.IOException e)
            {
                Console.WriteLine("Irgendwas ist schief gelaufen..... Probiere noch ein mal");
            }

            Console.Beep(1500, 1500);
            Console.Clear();
            Console.WriteLine("Wir fangen an!\n");
            Console.Beep(1500, 1500);
            Console.Clear();
        }
    }




    public abstract class RaetselKlasse
    {
        //internal static object quiz;

        public static void StelleFrage()
        {

        }
    }
    class Quiz : RaetselKlasse
    {

        public int punkte = 0;
        public new void StelleFrage()
        {

            string antwort1 = "";
            string antwort2 = "";
            string antwort3 = "";
            string antwort4 = "";
            string antwort5 = "";
            string antwort6 = "";
            string antwort7 = "";
            string antwort8 = "";
            string antwort9 = "";
            string antwort10 = "";

            //Frage1
            Console.WriteLine("Frage 1\nWer knurrt, wird aber niemals beißen? ");
            antwort1 = Console.ReadLine().ToLower();
            Console.Beep(1500, 1500);
            Console.Clear();
            if (antwort1 == "magen")
            {
                punkte = punkte + 1;
                Console.WriteLine("Bravo!\nDu hast jetzt:" + punkte + " Punkte\n");
            }
            else
            {
                Console.WriteLine("Falsch!\nDeine Punkte:" + punkte + "\n");

            }
            Console.Beep(1500, 1500);
            Console.Clear();



            //Frage 2
            Console.WriteLine("Frage 2\nWelches Tier ist reich?");
            antwort2 = Console.ReadLine().ToLower();
            Console.Beep(1500, 1500);
            Console.Clear();
            if (antwort2 == "schwein")
            {
                punkte = punkte + 1;
                Console.WriteLine("Bravo!\nDu hast jetzt: " + punkte + " Punkte\n");
            }
            else
            {
                Console.WriteLine("Falsch!\nDeine Punkte:" + punkte + "\n");
            }
            Console.Beep(1500, 1500);
            Console.Clear();


            //Frage 3
            Console.WriteLine("Frage 3\nWas macht wohl eine Bombe in einem Bordell?");
            antwort3 = Console.ReadLine().ToLower();
            Console.Beep(1500, 1500);
            Console.Clear();
            if (antwort3 == "puff")
            {
                punkte = punkte + 1;
                Console.WriteLine("Bravo!\nDu hast jetzt:" + punkte + " Punkte\n");
            }
            else
            {
                Console.WriteLine("Falsch!\nDeine Punkte:" + punkte + "\n");
            }
            Console.Beep(1500, 1500);
            Console.Clear();



            //Frage 4
            Console.WriteLine("Frage 4\nWas überwältigt auch den stärksten Mann? ");
            antwort4 = Console.ReadLine().ToLower();
            Console.Beep(1500, 1500);
            Console.Clear();
            if (antwort4 == "schlaf")
            {
                punkte = punkte + 1;
                Console.WriteLine("Bravo!\nDu hast jetzt: " + punkte + " Punkte\n");
            }
            else
            {
                Console.WriteLine("Falsch!\nDeine Punkte:" + punkte + "\n");
            }
            Console.Beep(1500, 1500);
            Console.Clear();



            //Frage 5
            Console.WriteLine("Frage 5\nIst es erlaubt, eine Tagesdecke auch nachts zu benutzen? ");
            antwort5 = Console.ReadLine().ToLower();
            Console.Beep(1500, 1500);
            Console.Clear();
            if (antwort5 == "nein")
            {
                punkte = punkte + 1;
                Console.WriteLine("Bravo!\nDu hast jetzt: " + punkte + " Punkte\n");
            }
            else
            {
                Console.WriteLine("Falsch!\nDeine Punkte:" + punkte + "\n");
            }
            Console.Beep(1500, 1500);
            Console.Clear();



            //Frage 6
            Console.WriteLine("Frage 6\nWer kommt grauhaarig auf die Welt?  ");
            antwort6 = Console.ReadLine().ToLower();
            Console.Beep(1500, 1500);
            Console.Clear();
            if (antwort6 == "esel")
            {
                punkte = punkte + 1;
                Console.WriteLine("Bravo!\nDu hast jetzt: " + punkte + " Punkte\n");
            }
            else
            {
                Console.WriteLine("Falsch!\nDeine Punkte:" + punkte + "\n");
            }
            Console.Beep(1500, 1500);
            Console.Clear();




            //Frage 7
            Console.WriteLine("Frage 7\nWie nennt man Nudel, die zwischen den Zähnen hängenbleibt? ");
            antwort7 = Console.ReadLine().ToLower();
            Console.Beep(1500, 1500);
            Console.Clear();
            if (antwort7 == "zahnpasta")
            {
                punkte = punkte + 1;
                Console.WriteLine("Bravo!\nDu hast jetzt: " + punkte + " Punkte\n");
            }
            else
            {
                Console.WriteLine("Falsch!\nDeine Punkte:" + punkte + "\n");
            }
            Console.Beep(1500, 1500);
            Console.Clear();


            //Frage 8
            Console.WriteLine("Frage 8\nWas haben Hündinnen, was sonst kein anderes Tier hat?  ");
            antwort8 = Console.ReadLine().ToLower();
            Console.Beep(1500, 1500);
            Console.Clear();
            if (antwort8 == "hundewelpen")
            {
                punkte = punkte + 1;
                Console.WriteLine("Bravo!\nDu hast jetzt: " + punkte + " Punkte\n");
            }
            else
            {
                Console.WriteLine("Falsch!\nDeine Punkte:" + punkte + "\n");
            }
            Console.Beep(1500, 1500);
            Console.Clear();



            //Frage 9
            Console.WriteLine("Frage 9\nWas wird auch unter freiem Himmel niemals von der Sonne berührt? ");
            antwort9 = Console.ReadLine().ToLower();
            Console.Beep(1500, 1500);
            Console.Clear();
            if (antwort9 == "schatten")
            {
                punkte = punkte + 1;
                Console.WriteLine("Bravo!\nDu hast jetzt: " + punkte + " Punkte\n");
            }
            else
            {
                Console.WriteLine("Falsch!\nDeine Punkte:" + punkte + "\n");
            }
            Console.Beep(1500, 1500);
            Console.Clear();



            //Frage 10
            Console.WriteLine("Frage 10\nWer hat Hühneraugen am Kopf? ");
            antwort10 = Console.ReadLine().ToLower();
            Console.Beep(1500, 1500);
            Console.Clear();

            if (antwort10 == "huener")
            {
                punkte = punkte + 1;
                Console.WriteLine("Bravo!\nDu hast jetzt:" + punkte + " Punkte\n");
            }
            else
            {
                Console.WriteLine("Falsch!\nDeine Punkte:" + punkte + "\n");
            }
            Console.Beep(1500, 1500);
            Console.Clear();
            Punkte(punkte);
            Console.ReadKey();


        }

        public void Punkte(int punkte)
        {
            if (punkte == 10)
            {
                Console.WriteLine("Bravo, du bist ein Genie!!!");
            }
            else if (punkte <= 9 && punkte >= 7)
            {
                Console.WriteLine("Bravo, du hast das gut geschafft!!!");
            }
            else
            {
                Console.WriteLine("Leider ist nicht so toll gegangen :(   !!!");
            }
            Console.Beep(1500, 1500);
            Console.Clear();
            Console.WriteLine("Magst du noch mal spielen?? für ja drücke 'j', für nein drücke 'x' ");
            string wahl = Console.ReadLine();

            try
            {
                if (wahl == "j")
                {
                    Program.Start();
                }

                if (wahl == "x")
                {
                    Environment.Exit(0);
                }
            }
            catch (System.IO.IOException e)
            {
                Console.WriteLine("Irgendwas ist schief gelaufen..... Probiere noch ein mal");
            }

        }
    }




    class Mathequiz : RaetselKlasse
    {
        public void Stellefrage()
        {
            string[] fragen = {
            "3+4=",
            "1+1=",
            "1+8=",
            "9+0=",
            "7-4=",
            "3+9=",
            "2+6=",
            "2-2=",
            "1+6=",
            "2+9=" };

            string[] antworten = { "7", "2", "9", "9", "3", "12", "8", "0", "7", "11" };
            string studentAntwort;
            int punkte = 0;
            int fragenzaehler = 0;
            int fragenNumer = 0;
            int antwortNumer = 0;
            while (fragenNumer < fragen.Length)
            {
                Console.WriteLine(fragen[fragenNumer], 10, 30);
                studentAntwort = Console.ReadLine();
                if (studentAntwort == antworten[antwortNumer])
                {
                    punkte++;
                    Console.WriteLine("Super! du hast " + punkte + " punkte");
                    fragenNumer++;
                    antwortNumer++;
                    fragenzaehler++;
                }
                else
                {
                    Console.WriteLine("Nicht soooo tolll!!! Du hast " + punkte + " punkte");
                    fragenNumer++;
                    antwortNumer++;
                    fragenzaehler++;
                }
                Console.WriteLine();
                Console.WriteLine("Drücke ENTER für die nächste Frage.");
                Console.ReadLine();
                Console.Clear();

            }

            Console.WriteLine();
            Punkte(punkte);
            Console.ReadKey();
        }

        public void Punkte(int punkte)
        {
            if (punkte == 10)
            {
                Console.WriteLine("Bravo, du bist ein Genie!!!");
            }
            else if (punkte <= 9 && punkte >= 7)
            {
                Console.WriteLine("Bravo, du hast das gut geschafft!!!");
            }
            else
            {
                Console.WriteLine("Leider ist nicht so toll gegangen :(   !!!");
            }
            Console.Beep(1500, 1500);
            Console.Clear();
            Console.WriteLine("Magst du noch mal spielen?? für ja drücke 'j', für nein drücke 'x' ");
            string wahl = Console.ReadLine();

            try
            {
                if (wahl == "j")
                {
                    Program.Start();
                }

                if (wahl == "x")
                {
                    Environment.Exit(0);
                }
            }
            catch (System.IO.IOException e)
            {
                Console.WriteLine("Irgendwas ist schief gelaufen..... Probiere noch ein mal");
            }

        }
    }
}
    



