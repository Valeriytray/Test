namespace UDD
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Drivers
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id { get; set; }

        [StringLength(50)]
        public string name { get; set; }

        [StringLength(50)]
        public string middlename { get; set; }

        [Column("passport serial")]
        public int? passport_serial { get; set; }

        [Column("passport number")]
        public int? passport_number { get; set; }

        [StringLength(255)]
        public string postcode { get; set; }

        [StringLength(255)]
        public string address { get; set; }

        [Column("address life")]
        [StringLength(255)]
        public string address_life { get; set; }

        [StringLength(255)]
        public string company { get; set; }

        [StringLength(255)]
        public string jobname { get; set; }

        [StringLength(20)]
        public string phone { get; set; }

        [StringLength(255)]
        public string email { get; set; }

        [StringLength(255)]
        public string photo { get; set; }

        public string description { get; set; }

        public virtual License License { get; set; }
    }
}
