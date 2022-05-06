using System;
using System.Collections.Generic;
using System.Text;
using SQLite;

namespace Magazin.Models
{
    public class Client
    {
        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }
        public string Mail { get; set; }
        public string Username { get; set; }
        public string Parola { get; set; }
        public string Parola2 { get; set; }
        public string Nume { get; set; }
        public string Prenume { get; set; }
        public string Telefon { get; set; }
        public DateTime Data_nast { get; set; }
        public string Adresa { get; set; }
    }
}
