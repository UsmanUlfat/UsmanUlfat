namespace UsmanProj.Data
{
    public class Classs
    {
        [key]
        public int cid {  get; set; }
        public string name { get; set; }
        public int roomno { get; set; }
        public Faculty fid { get; set; }
    }
}
