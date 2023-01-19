using prueba.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace prueba.ViewModels
{
    public class CustomerFormViewModel
    {
        public List<MembershipType> MembershipTypes { get; set; }
        public Customer Customer { get; set; }
    }
}