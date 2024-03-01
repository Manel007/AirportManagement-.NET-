using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace AM.ApplicationCore.Domain
{
    public class Passenger
    {
        public Passenger()
        {
        }

        public Passenger(string FirstName, string LastName)
        {
           
            FirstName = FirstName;
            LastName = LastName;
        }
        public int Id { get; set; }
        [Display(Name = "Date of Birth")]
        [DataType(DataType.DateTime)]
        public DateTime BirthDate { get; set; }

        [StringLength(7)]
        public string PassportNumber { get; set; }
        [DataType(DataType.EmailAddress)]
        public string EmailAddress { get; set;}

        [MaxLength(25, ErrorMessage = "firstname must be between 23-25 ")]
        [MinLength(3, ErrorMessage = "firstname must be between 23-25 ")]
        public string FirstName { get; set;}
        public string LastName { get; set;}
     //   [Range(8, 8)]
        [RegularExpression(@"^[0-9]{8}$",ErrorMessage ="invalid phone number")]
        public int TelNumber { get; set;}

        public override string ToString()
        {
            return $"flight: passportnumber {PassportNumber}, Firstname{FirstName}";
        }

        public bool CheckProfile(string firstName, string LastName)
        {
            return firstName == firstName;
        }



        public virtual void PassengerType()
        {
            Console.WriteLine("Im a Passenger");
        }
    }

}
