using System;
using System.Collections.Generic;
using soccerApp.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace soccerApp.Models
{
    public class Player
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public int PlayerID { get; set; }
        //The FirstName+LastName must be unique. This functions as a sort of composite key
        [Required]
        [Index("FirstNameLastName", 1, IsUnique = true)]
        [MaxLength(450)]
        [Display(Name = "First Name")]
        public string FirstName { get; set; }
        [Required]
        [Index("FirstNameLastName", 2, IsUnique = true)]
        [MaxLength(450)]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }

        //Only used for mapping on Team/Details View. Might be redundant
        public string FullName
        {
            get
            {
                return FirstName + " " + LastName;
            }
        }

        [ForeignKey("TeamID")]
        public virtual Team Team { get; set; }
        public int TeamID { get; set; }
    }
}