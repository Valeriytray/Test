namespace UDD
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("License")]
    public partial class License
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

        [Column("licence date", TypeName = "date")]
        public DateTime? licence_date { get; set; }

        [Column("expire date", TypeName = "date")]
        public DateTime? expire_date { get; set; }

        [StringLength(255)]
        public string categories { get; set; }

        [Column("licence series")]
        public int? licence_series { get; set; }

        [Column("licence number")]
        public int? licence_number { get; set; }

        [StringLength(255)]
        public string Status { get; set; }

        [StringLength(255)]
        public string VIN { get; set; }

        [StringLength(255)]
        public string Manufacturer { get; set; }

        [StringLength(255)]
        public string Model { get; set; }

        public int? Year { get; set; }

        public int? Weight { get; set; }

        [StringLength(255)]
        public string Color { get; set; }

        [Column("Engine Type")]
        public int? Engine_Type { get; set; }

        [Column("type of drive")]
        [StringLength(20)]
        public string type_of_drive { get; set; }

        public virtual Drivers Drivers { get; set; }
    }
}
