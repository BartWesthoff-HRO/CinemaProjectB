using CinemaProjectB.DAL;
using CinemaProjectB.Pages;
using System;
using System.Collections.Generic;


public class Movie
{
    public DateTime Start;
    public DateTime End;
    public string Name;

    public Movie(DateTime start, DateTime end, string name)
    {
        Start = start;
        End = end;
        Name = name;
    }
}
class Program
{
    public static void Main()
    {
        //DataStorageHandler.Init("Projectb.json");
        DateTime st = new DateTime(2021, 1, 1, 10, 0, 0);
        DateTime ed = st.AddHours(2);
        string name = "Iron man";
        Movie movie = new Movie(st, ed, name);

        DateTime st2 = new DateTime(2021, 1, 1, 13, 0, 0);
        DateTime ed2 = st2.AddHours(2);
        string name2 = "Iron man";
        Movie movie2 = new Movie(st2, ed2, name2);


        DateTime closed = new DateTime(2021, 1, 1, 20, 0, 0);

        DateTime st3 = new DateTime(2021, 1, 1, 14, 0, 0);
        DateTime ed3 = st3.AddHours(2);
        string name3 = "Iron man";
        Movie movie3 = new Movie(st3, ed3, name3);

        Movie mov = new Movie(st, ed, name);
        for (int i =0; i < 8; i++)
        {
            
            int movietime = 1; //hour
          
            if(mov.End.AddHours(movietime) < closed)
            {
                Console.WriteLine($"Volgende film kan draaien om kan draaien om {mov.End.AddHours(movietime)}");
                mov.End = mov.End.AddHours(movietime);
                
            }
           
        }
       // InsertMovie(new DateTime(2021, 1, 1, 15, 0, 0), new DateTime(2021, 1, 1, 18, 0, 0), "Iron man", 2); // werkt wel
        InsertMovie(new DateTime(2021, 1, 1, 15, 0, 0), new DateTime(2021, 1, 1, 21, 0, 0), "Iron man", 2); // werkt niet

    }

    public static void InsertMovie(DateTime start, DateTime end, string name, int zaal)
    {
        DateTime closed = new DateTime(2021, 1, 1, 20, 0, 0);
        int cleaning = 30;
     
       // DateTime ed = st.AddHours(2);
        Movie movietoinput = new Movie(start, end, name);
        List<Movie> movies = new List<Movie>
        {
            new Movie(new DateTime(2021,1,1,10,0,0), new DateTime(2021,1,1,12,0,0), "Iron man"), // werkt wel want end.hours = 12+clean = 12.5 is < start.hours = 15
           // new Movie(new DateTime(2021,1,1,10,0,0), new DateTime(2021,1,1,15,0,0), "Iron man"), //werkt niet want end.hours = 15 + clean = 15.5 is > start.hours = 15

        };

        bool add = false;
        foreach (var item in movies)
        {
            if(item.End.AddMinutes(cleaning) < start && end < closed && item.Name == name && start < closed)
            {
                add = true;
                Console.WriteLine("gelukt");
            }
            Console.WriteLine($" item.End.AddMinutes(cleaning) < start = {item.End.AddMinutes(cleaning) < start}");
            Console.WriteLine($"end < closed = {end < closed}");
            Console.WriteLine($"item.Name == name = {item.Name == name}");
            Console.WriteLine($"start < closed = {start < closed}");
         
        }
        if (add) { movies.Add(new Movie(start,end, name)); } //Collection modified error
    }
}