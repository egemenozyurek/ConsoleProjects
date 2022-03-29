using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ContactAppProject1 {
    public class Persons {
        static List<Persons> _personlist;

        static Persons () {
            _personlist = new List<Persons> {
                new Persons { Name = "Veronica", Surname = "Velazquez", PhoneNumber = "0641-272-79-21" },
                new Persons { Name = "Jermaine", Surname = "Mcintosh", PhoneNumber = "0369-638-40-01" },
                new Persons { Name = "Kenyon", Surname = "Puckett", PhoneNumber = "0441-675-38-76" },
                new Persons { Name = "Camden", Surname = "Bradford", PhoneNumber = "0963-275-62-87" },
                new Persons { Name = "Curran", Surname = "Soto", PhoneNumber = "0799-446-05-04" }
            };
        }

        public string Name { get; set; }

        public string Surname { get; set; }

        public string PhoneNumber { get; set; }

        public static bool AddPerson (string name, string surname, string phoneNumber) {
            if (!string.IsNullOrWhiteSpace (name) && (!string.IsNullOrWhiteSpace (surname) && (!string.IsNullOrWhiteSpace (phoneNumber)))) {
                Persons person = new Persons ();
                person.Name = name;
                person.Surname = surname;
                person.PhoneNumber = phoneNumber;
                _personlist.Add (person);
                return true;
            } else
                return false;
        }

        public static List<Persons> GetAll () {
            return _personlist;
        }

        public static bool Remove (Persons item) {
            if (item != null) {
                _personlist.Remove (item);
                return true;
            } else
                return false;

        }

        public static Persons Update (string name, string surname, string phonenumber, Persons person) {
            bool success = PhoneFormatControl (phonenumber);
            if (!string.IsNullOrWhiteSpace (name) && (!string.IsNullOrWhiteSpace (surname) && (!string.IsNullOrWhiteSpace (phonenumber))) && (person != null) && (success)) {
                person.Name = name;
                person.Surname = surname;
                person.PhoneNumber = phonenumber;
                return person;
            } else
                return null;
        }

        public static Persons GetPerson (string name) {
            foreach (var item in Persons.GetAll ()) {
                if (name == item.Name || name == item.Surname)
                    return item;
            }
            return null;

        }

        public static void GetList () {
            Console.WriteLine ("------- Kişi Listesi -------\n");
            foreach (var item in Persons.GetAll ()) {
                Console.WriteLine ("İsim: " + item.Name);
                Console.WriteLine ("Soyisim: " + item.Surname);
                Console.WriteLine ("Numara: " + item.PhoneNumber);
                Console.WriteLine ("-");
            }
        }

        public static List<Persons> GetListforNameorSurname (string nameorsurname) {
            List<Persons> personlist = new List<Persons> ();
            foreach (var item in Persons.GetAll ()) {
                if (nameorsurname == item.Name || nameorsurname == item.Surname) {
                    personlist.Add (item);
                }
            }
            return personlist;
        }

        public static void GetListForAlphabet (int alphabetType) {
            List<Persons> sortedList = Persons.GetAll ().OrderBy (n => n.Name).ToList ();

            if (alphabetType == 1) {
                foreach (var item in sortedList) {
                    Console.WriteLine ("İsim:" + item.Name);
                    Console.WriteLine ("Soyisim:" + item.Surname);
                    Console.WriteLine ("Telefon Numarası:" + item.PhoneNumber);
                    Console.WriteLine ("-");
                }
            } else if (alphabetType == 2) {
                sortedList.Reverse ();
                foreach (var item in sortedList) {
                    Console.WriteLine ("İsim:" + item.Name);
                    Console.WriteLine ("Soyisim:" + item.Surname);
                    Console.WriteLine ("Telefon Numarası:" + item.PhoneNumber);
                    Console.WriteLine ("-");
                }
            }
        }
        public static List<Persons> GetListforNumber (string searchPhoneNumber) {
            List<Persons> personlist = new List<Persons> ();
            foreach (var item in Persons.GetAll ()) {
                if (searchPhoneNumber == item.PhoneNumber) {
                    personlist.Add (item);
                }
            }
            return personlist;
        }

        public static bool PhoneFormatControl (string phonenumber) {
            string phoneControl = @"^(0(\d{3})-(\d{3})-(\d{2})-(\d{2}))$";
            Match check = Regex.Match (phonenumber, phoneControl, RegexOptions.IgnoreCase);
            return check.Success;
        }
    }
}