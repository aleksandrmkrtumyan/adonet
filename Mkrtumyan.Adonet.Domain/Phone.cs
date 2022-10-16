using System;
using System.ComponentModel.DataAnnotations;

namespace Mkrtumyan.Adonet.Domain
{
    public class Phone
    {
        /// <summary>
        /// Id
        /// </summary>
        [Display(Name = "Id")]
        public Guid Id { get; set; }
        
        /// <summary>
        /// PhoneNumber
        /// </summary>
        [Display(Name = "PhoneNumber")]
        public string PhoneNumber { get; set; }
    }
}