using System.ComponentModel.DataAnnotations;

namespace UsmanProj.Data
{
    public class Enrolled
    {
        [Key]
        public int Id { get; set; }
        public Student sid { get; set; }

        public Classs cid { get; set; }

    }
}
