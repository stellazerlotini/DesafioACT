using Azure;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace WebApplicationAcc.Models
{
    public class Supplier
    {
        public int SupplierId { get; set; }

        public string CNPJCPF { get; set; }

        public string RG { get; set; }

        public DateTime DateOfBirth { get; set; }

        public string Name { get; set; }

        public string Email { get; set; }

        public string ZipCode { get; set; }

        public List<Company> Companies{ get; set; }

   

    }
}
