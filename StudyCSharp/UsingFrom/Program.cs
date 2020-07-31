using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsingFrom
{
    #region
    class Profile
    {
        public string Name { get; set; }
        public int Height { get; set; }
    }
    #endregion

    class Class
    {
        public string Name { get; set; }
        public int[] Score { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            #region 
            //List<Profile> profiles = new List<Profile>
            //{
            //    new Profile {Name = "정우성", Height = 186},
            //    new Profile {Name = "장동건", Height = 176},
            //    new Profile {Name = "원빈", Height = 166},
            //    new Profile {Name = "고현정", Height = 127},
            //    new Profile {Name = "이문세", Height = 178},
            //};

            //var newProfiles = from item in profiles
            //                  where item.Height < 175
            //                  orderby item.Name
            //                  select new
            //                  {
            //                      Name = item.Name,
            //                      InchHeight = item.Height * 0.393,
            //                  };
            //foreach (var item in newProfiles)
            //{
            //    Console.WriteLine($"{item.Name}, {item.InchHeight}");
            //}
            #endregion
            Class[] arrClass =
            {
                new Class(){Name = "연두반", Score = new int[]{99,80,70,24}},
                new Class(){Name = "분홍반", Score = new int[]{60,45,87,72}},
                new Class(){Name = "파랑반", Score = new int[]{92,30,85,94}},
                new Class(){Name = "노랑반", Score = new int[]{90,88,0,17}}
            };

            var classes = from c in arrClass
                          from s in c.Score
                          where s < 60
                          orderby s
                          select new { c.Name, Lowest = s };

            foreach (var item in classes)
            {
                Console.WriteLine($"낙제 : {item.Name} ({item.Lowest})");
            }

        }
    }
}
