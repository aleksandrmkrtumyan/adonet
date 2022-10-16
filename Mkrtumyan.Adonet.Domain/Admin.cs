using System;
using System.ComponentModel.DataAnnotations;

namespace Mkrtumyan.Adonet.Domain
{
    public class Admin
    {
        /// <summary>
        /// Id
        /// </summary>
        [Display(Name = "Id")]
        public Guid Id { get; set; }
        
        /// <summary>
        /// Username
        /// </summary>
        [Display(Name = "Username")]
        public string Username { get; set; }
        
        /// <summary>
        /// Password
        /// </summary>
        [Display(Name = "Password")]
        public string Password { get; set; }
        
        /// <summary>
        /// Auth token
        /// </summary>
        [Display(Name = "AuthToken")]
        public Guid AuthToken { get; set; }

    }
}
