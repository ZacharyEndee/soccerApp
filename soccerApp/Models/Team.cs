using System;
using soccerApp.Models;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace soccerApp.Models
{
    public class Team
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public int TeamID { get; set; }
        /*Team Name must be unique and under 100 characters (the IsUnique
         * will not be performed if a limit isn't placed on the string)
        */
        [Required]
        [Index(IsUnique = true)]
        [StringLength(100)]
        [Display(Name ="Team Name")]
        public string TeamName { get; set; }

        public virtual List<Player> Players { get; set; }
    }
}