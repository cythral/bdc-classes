using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace BrekkeDanceCenter.Classes.Entities {
    public class Class {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long ClassId { get; set; }

        [ForeignKey("CourseId")]
        public Course Course { get; set; }

        public string Name { get; set; }

        public string Url { get; set; } 
    }
}