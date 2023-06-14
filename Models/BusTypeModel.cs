using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace bus_project.Models;

public class BusTypeModel
{
    [Table("model")]
    public class BusType
    {
        [Key]
        public string model_name { get; set; }
        public int engine_power { get; set; }
        public string category { get; set; }
        public int permitted_weight { get; set; }
        public int unladen_mass { get; set; }
        public int year_release { get; set; }
    }
}