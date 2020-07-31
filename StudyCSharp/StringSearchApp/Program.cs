using System;
using System.Diagnostics.Tracing;
using System.Globalization;
using static System.Console;


namespace StringSearchApp
{
    class Program
    {
        static void Main(string[] args)
        {
            string g = "Good Morning";
            //WriteLine(g);
            //WriteLine($"IndexOf 'Good' : {g.IndexOf("ood")}");
            //WriteLine($"LestIndexOf 'Good' : {g.LastIndexOf("Good")}");
            //WriteLine($"IndexOf 'n' : {g.IndexOf("n")}");
            //WriteLine($"LestIndexOf 'n' : {g.LastIndexOf("n")}");

            //WriteLine($"StartsWith 'Good' : {g.StartsWith("Good")}");
            //WriteLine($"StartsWith 'Morning' : {g.StartsWith("Morning")}");

            //WriteLine($"Contains 'Good' : {g.Contains("Good")}");

            //WriteLine($"Replace 'Morning' to 'Evening' : " + $"{g.Replace("Morning", "Evening")}");
            //if(g.Contains("Morning"))
            //{
            //    g.Replace("Morning", "Evening");
            //}

            //WriteLine($"ToLower : {g.ToLower()}");
            //WriteLine($"ToUpper : {g.ToUpper()}");
            //WriteLine($"Insert : {g.Insert(g.IndexOf("Morning")-1,"Very")}");

            //WriteLine($"Remove : '{"I don't Love You".Remove(2, 6)}'");
            //WriteLine($"Trim : '{" No Space ".Trim()}'");
            //WriteLine($"Trim : '{" No Space ".TrimStart()}'");
            //WriteLine($"Trim : '{" No Space ".TrimEnd()}'");
            //string codes = "MSFT,GOOG,AMAN,AAPL,PHT";
            //var result = codes.Split(',');
            //foreach (var item in result)
            //{
            //    WriteLine($"each item : '{item.Trim()}'");
            //}

            //WriteLine($"substring : {g.Substring(0,4)}");

            WriteLine(string.Format("{0}DEF", "ABC"));

            DateTime dt = DateTime.Now;
            WriteLine(string.Format("{0:yyyy-MM-dd HH:mm:ss}", dt));
            WriteLine(string.Format("{0:d/M/yyyy HH:mm:ss}", dt));

            WriteLine(dt.ToString("yyyy-MM-dd HH:mm:ss", new CultureInfo("ko-KR")));
            WriteLine(dt.ToString("d/M/yyyy HH:mm:ss", new CultureInfo("en-US")));
        }
    }
}
