using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace BrekkeDanceCenter.Classes.Entities {
    public class Course {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long Id { get; set; }

        public string Name { get; set; }

        public string LiveLink { get; set; }

        public ICollection<Class> Classes { get; set; }
    }
}