using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace BrekkeDanceCenter.Classes.Entities {
    public class Class {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long ClassId { get; set; }

        [ForeignKey("CourseId")]
        [JsonIgnore]
        public Course Course { get; set; }

        public string Name { get; set; }

        public string YoutubeId { get; set; } 
    }
}