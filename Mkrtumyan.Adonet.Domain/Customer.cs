using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Mkrtumyan.Adonet.Domain
{
    public class Customer
    {
        /// <summary>
        /// Id
        /// </summary>
        [Display(Name = "Id")]
        public Guid Id { get; set; }
        
        /// <summary>
        /// Name
        /// </summary>
        [Display(Name="Name")]
        public string Name { get; set; }
        
        /// <summary>
        /// LastName
        /// </summary>
        [Display(Name = "LastName")]
        public string LastName { get; set; }

        /// <summary>
        /// Phones
        /// </summary>
        [Display(Name = "Phones")]
        public ICollection<Phone> Phones { get; set; } = new HashSet<Phone>();

        /// <summary>
        /// Documents
        /// </summary>
        [Display(Name = "Documents")]
        public ICollection<Document> Documents { get; set; } = new HashSet<Document>();

    }
}