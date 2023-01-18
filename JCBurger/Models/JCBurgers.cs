using SQLite;

namespace JCBurger.Models
{
    [Table("JCBurger")]
    public class JCBurgers
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        [MaxLength(250), Unique]
        public string JCName { get; set; }
        public string JCDescription { get; set; }
        public bool JCWithExtraCheese { get; set; }
    }
}
