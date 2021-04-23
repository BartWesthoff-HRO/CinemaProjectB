using System;
using System.Collections.Generic;
using System.Text;
using CinemaProjectB.Classes;
using CinemaProjectB.DAL;
using static System.Console;

namespace CinemaProjectB
{
    public class SeatsMenu
    {
        public  int SelectedRow;
        public  int SelectedColumn;
        public  object[][] seats;
        public readonly  string Prompt;


        public SeatsMenu(string prompt, object[][] seats_)
        {
            Prompt = prompt;
            seats = seats_;
            SelectedColumn = 0;
            SelectedRow = 0;
          
        }

        public void Display()
        {
            Clear();
            WriteLine(Prompt);
            for (int i =0; i < seats.Length; i++)
            {
                string row = "";
                for(int j =0; j < seats[i].Length; j++)
                {
                    row += seats[i][j];
                    if(i == SelectedRow && j == SelectedColumn)
                    {
                        ForegroundColor = ConsoleColor.Black;
                        BackgroundColor = ConsoleColor.White;
                    }
                    else
                    { 
                        ForegroundColor = ConsoleColor.White;
                        BackgroundColor = ConsoleColor.Black;
                    }
                    if(seats[i][j] is Seat)
                    {
                        Write("[*]");
                    }
                    else if (seats[i][j] is null)
                    {
                        Write("[||]");
                    }
                    else {
                        Write("[NOT A SEAT]");
                    }
                    
                }
                WriteLine("");
            }
           
        }

        public Seat Run()
        {
            ConsoleKey keyPressed = ConsoleKey.B;
            while (keyPressed != ConsoleKey.Enter)
            {
                Clear();
                Display();
                ConsoleKeyInfo keyInfo = ReadKey(true);
                keyPressed = keyInfo.Key;

                if (keyPressed == ConsoleKey.DownArrow)
                {
                    SelectedRow++;

                    if (SelectedRow > seats.Length - 1)
                    {
                        SelectedRow = seats.Length - 1;
                    }
                }
                if (keyPressed == ConsoleKey.UpArrow)
                {
                    SelectedRow--;
                    if (SelectedRow < 0)
                    {
                        SelectedRow = 0;
                    }
                }

                if (keyPressed == ConsoleKey.LeftArrow)
                {
                    SelectedColumn--;
                    if (SelectedColumn < 0)
                    {
                        SelectedColumn = 0;
                    }
                }
                if (keyPressed == ConsoleKey.RightArrow)
                {
                    SelectedColumn++;
                    if (SelectedColumn > seats.Length -1)
                    {
                        SelectedColumn = seats.Length -1 ;
                    }
                }
                ResetColor();

            }
            Seat selectedseat = new Seat
            {
                Row = SelectedRow,
                Column = SelectedColumn
            };
            // List<int> selectedSeat = new List<int> { selectedseat.Row, selectedseat.Column };
            //  selectedSeat = new List<int> { SelectedRow, SelectedColumn };
            return selectedseat;
        }
    }
}
