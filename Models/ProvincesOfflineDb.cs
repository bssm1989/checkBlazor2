

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
    public class Amper
    {
        public int Id { get; set; }
        public string Fullname { get; set; }

    }
    
  
}
