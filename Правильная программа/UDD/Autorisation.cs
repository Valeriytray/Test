namespace UDD
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Autorisation")]
    public partial class Autorisation
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(20)]
        public string Login { get; set; }

        [Key]
        [Column(Order = 1)]
        public string Password { get; set; }
    }
}
