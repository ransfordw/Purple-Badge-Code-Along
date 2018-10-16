using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_Defining_Classes_3
{
    public class SalesTeamMember
    {
        public SalesTeamMember() {}
        public SalesTeamMember(string name, decimal sales)
        {
            LastName = name;
            TotalSales = sales;
        }

        public string LastName { get; set; }
        public decimal TotalSales { get; set; }
    }

    //public enum MovementType { Walk = 1, Fly, Swim}
    //public class Bird
    //{

    //    public Bird() {}
    //    public Bird(string name, bool talons, MovementType move, int eggs)
    //    {
    //        Name = name;
    //        HasTalons = talons;
    //        MovementType = move;
    //        NumberOfEggs = eggs;
    //    }
    //    public string Name { get; set; }
    //    public bool HasTalons { get; set; }
    //    public MovementType MovementType { get; set; }
    //    public int NumberOfEggs { get; set; }
    //}
}
