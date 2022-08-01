namespace DesarrolloSocialWeb.Models
{
    public class PaisesModel
    {
        public Name? name { get; set; }

        public bool error { get; set; }
        public string msg { get; set; }
        public List<Datum> data { get; set; }
    }

    public class Name
    {
        public string? common { get; set; }
        public string? official { get; set; }
        //public NativeName nativeName { get; set; }
    }
    public class Datum
    {
        public string iso2 { get; set; }
        public string iso3 { get; set; }
        public string country { get; set; }
        public List<string> cities { get; set; }
    }

}
