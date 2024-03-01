using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace AM.ApplicationCore.Domain
{
    public class Staff:Passenger
    {
     /*   public Staff(DateTime employementDate, string function, int salary)
        {

            EmployementDate = employementDate;
            Function = function;
            Salary = salary;
        }
     */
        public Staff()
        {
        }

        public DateTime EmployementDate { get; set; }
        
        public string  Function { get; set; }
        [DataType(DataType.Currency)]
        public int Salary { get; set; }


        public override void PassengerType()
        {
            Console.WriteLine("Im a traveller");
        }

    }
}
