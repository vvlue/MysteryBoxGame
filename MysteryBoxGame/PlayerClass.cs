using System;
using System.Collections.Generic;
using System.Text;

namespace MysteryBoxGame
{
    public class PlayerClass
    {
        
        private string name;
        private int wallet;
       
        private BoxClass[,] rounds = new BoxClass[50,3];

        private int roundCounter = 0;


        public PlayerClass(string n, int w)
        {
            name = n;
            wallet = w;

        }

        public void PlayRound(int type)
        {
            if (type == 1)
            {
                wallet -= 5;

            }
            else if (type == 2)
            {
                wallet -= 10;

            }
            else
            {
                wallet -= 15;

            }

            for (int i = 0; i < 3; i++)
            {

                rounds[roundCounter, i] = new BoxClass(type);

            }

            roundCounter++;


        }

        public List<int> OpenBoxes()
        {
            List<int> Values = new List<int>();

            for (int i = 0; i < 3; i++)
            {
                Values.Add(rounds[roundCounter - 1, i].GetValue());


            }

            foreach (var value in Values)
            {
                wallet += value;

            }

            return Values;




        }












        //public float CalculateAvg()
        //{
        //    float avg;
        //    int sumMarks = 0;



        //    foreach (int mark in marks)
        //    {
        //        sumMarks += mark;
        //    }



        //    avg = sumMarks / 5;
        //    avg = (float)Math.Round(avg, 1);



        //    return avg;
        //}



        //private void AnalyseGrade()
        //{
        //    if (CalculateAvg() >= 80)
        //    {
        //        symbol = 'A';
        //        comment = "Congrats!";




        //    }
        //    else if (CalculateAvg() >= 40)
        //    {
        //        symbol = 'P';
        //        comment = "You can do better.";
        //    }
        //    else
        //    {
        //        symbol = 'F';
        //        comment = "You need  to so something about this!";
        //    }
        //}



        //public string StudentSummary()
        //{
        //    return "Name: " + name + "\t5-Mark average: " + CalculateAvg() + "% Symbol: " + symbol +
        //        "\nCommnet: " + comment;
        //}



        //public char GetSymbol()
        //{
        //    return symbol;
        //}



        public string GetName()
        {
            return name;
        }



        //public override string ToString()
        //{
        //    string fields = name + "";



        //    foreach (int mark in marks)
        //    {
        //        fields += mark + " ";
        //    }



        //    fields += "\n" + symbol + "\n" + comment;



        //    return fields;
        //}
    }
}
