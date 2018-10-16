using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_Defining_Classes_3
{
    public class SalesTeamMemberRepository
    {
        private SalesTeamMember _salesMember = new SalesTeamMember();
        private List<SalesTeamMember> _memberList = new List<SalesTeamMember>();
        private List<SalesTeamMember> _topSalesMembers = new List<SalesTeamMember>();
        private List<SalesTeamMember> _lowestSalesMembers = new List<SalesTeamMember>();

        //--Passed
        public void AddMemberToList(SalesTeamMember member)
        {
            _memberList.Add(member);
        }

        public List<SalesTeamMember> GetMemberList()
        {
            return _memberList;
        }

        //--Passed
        public decimal GetSalesForMember(SalesTeamMember member)
        {
            decimal memberSales = member.TotalSales;
            return memberSales;
        }

        //--Passed
        public decimal GetTotalSales()
        {
            var totalSales = 0m;
            GetMemberList();
            foreach (SalesTeamMember member in _memberList)
                totalSales += member.TotalSales;
            return totalSales;
        }

        //--Passed
        public decimal GetLowestSales()
        {
            var lowest = _memberList.Min(s => s.TotalSales);
            return lowest;
        }

        //--Passed
        public decimal GetHighestSales()
        {
            decimal highestSales = 0m;
            GetMemberList();
            List<decimal> sales = new List<decimal>();
            foreach (SalesTeamMember member in _memberList)
                sales.Add(GetSalesForMember(member));
            highestSales = sales.Max();
            return highestSales;
        }

        public List<SalesTeamMember> GetTopSellers()
        {
            var highestNum = GetHighestSales();
            var _topSalesMembers = _memberList.FindAll(x => x.TotalSales == highestNum);
            return _topSalesMembers;
        }

        public List<SalesTeamMember> GetLowestSellers()
        {
            var lowestNum = GetLowestSales();
            var _lowestSalesMembers = _memberList.FindAll(x => x.TotalSales == lowestNum);
            return _lowestSalesMembers;
        }

    }
}
