namespace BTracker_COMP229.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class game
    {
        [Required]
        [StringLength(20)]
        public string home_team { get; set; }

        [Required]
        [StringLength(20)]
        public string away_team { get; set; }

        [Required]
        [StringLength(20)]
        public string winner { get; set; }

        public int spectators { get; set; }

        public int game_num { get; set; }

        public int home_score { get; set; }

        public int away_score { get; set; }

        [Column(TypeName = "date")]
        public DateTime game_date { get; set; }

        [Required]
        [StringLength(20)]
        public string loser { get; set; }

        public int week { get; set; }

        public int GameID { get; set; }
    }
}
