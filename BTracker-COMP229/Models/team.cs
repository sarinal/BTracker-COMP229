namespace BTracker_COMP229.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class team
    {
        [Column("team")]
        [StringLength(20)]
        public string team1 { get; set; }

        public int? wins { get; set; }

        public int? losses { get; set; }

        [StringLength(8)]
        public string league { get; set; }

        [StringLength(10)]
        public string division { get; set; }

        [Key]
        [StringLength(3)]
        public string team_id { get; set; }
    }
}
