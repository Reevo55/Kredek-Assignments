using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RadoslawKarbowiakLab6Zadanie.Models
{
    public class ClientViewModel
    {
        /// <summary>
        /// Imie
        /// </summary>
        public string FirstName { get; set; }
        /// <summary>
        /// Nazwisko
        /// </summary>
        public string SecondName { get; set; }
        /// <summary>
        /// Rachunek
        /// </summary>
        public double Bill { get; set; }
        /// <summary>
        /// Zamówienie
        /// </summary>
        public string Order { get; set; }

        public ClientViewModel() { }

        public ClientViewModel(string firstName, string secondName, string order, double bill)
        {
            FirstName = firstName;
            SecondName = secondName;
            Order = order;
            Bill = bill;
        }
    }
}
