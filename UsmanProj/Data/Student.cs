namespace UsmanProj.Data
{
    public class Student
    {
        [key]
        public int sId { get; set; }
        public string sName { get; set; }
        public string major { get; set; }

        public int Standing {  get; set; }
    }
}
