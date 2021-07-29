

using DnetIndexedDb;

namespace FirstBlazorApp.Models
{
   
    public class Province
    {
        [IndexDbKey(AutoIncrement = true)]
        public int Id { get; set; }
        public string Fullname { get; set; }
       

}
  
   
    public class district
    {
        [IndexDbKey(AutoIncrement = true)]
        public string district_id { get; set; }
  
        public int province_id { get; set; }
  
        public string district_name_thai { get; set; }
   
        public string district_name_eng { get; set; }
  
        public int comment { get; set; }

    }
    public class tambon
    {
        [IndexDbKey(AutoIncrement = true)]

        public string tambon_id { get; set; }
        public string province_id { get; set; }
        public string district_id { get; set; }
        public string tambon_name_thai { get; set; }
        public string tambon_name_eng { get; set; }
        public string comment { get; set; }
        public string lat { get; set; }
        public string lng { get; set; }
    }
        public class province
    {
        [IndexDbKey(AutoIncrement = true)]

        public string province_id { get; set; }
        public int region_id { get; set; }
        public string province_name_thai { get; set; }
        public string province_name_eng { get; set; }
        public string comment { get; set; }
    }
        public class Amper
    {
        public int Id { get; set; }
        public string Fullname { get; set; }

    }
    
  
}
