﻿using System;
using System.Collections.Generic;
using System.Text;

namespace MysteryBoxGame
{
    class Player
    {
        //private string name;
        //private List<int> marks = new List<int>();
        //private char symbol;
        //private string comment;

        private string name;
        private int wallet;
        private int amount;



        public Player(string n, int w)
        {
            name = n;
            wallet = w;



           
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
