using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace DTO.Weathers
{
    public partial class Temp
    {
        [Key]
        public int Id { get; set; }
        public double Day { get; set; }
        public double Min { get; set; }
        public double Max { get; set; }
        public double Night { get; set; }
        public double Eve { get; set; }
        public double Morn { get; set; }
    }
}
