using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace CodeWarsSolutions
{
    public class NumberOfPeopleInTheBus
    {
        public static int Number(List<int[]> peopleListInOut)
        {
            var listOfPeopleIn = peopleListInOut.Select(x => x[0]).ToList();
            var listOfPeopleOut = peopleListInOut.Select(x => x[1]).ToList();

            var numberIn = listOfPeopleIn.Sum();
            var numberOut = listOfPeopleOut.Sum();

       
            var result = numberIn - numberOut;
            return result; 
        
        }
    }
}

//BETTER SOLUTION
/*
 public static int Number(List<int[]> peopleListInOut)
  {
    return peopleListInOut.Sum(Item => Item[0] - Item[1]);
  }
*/
