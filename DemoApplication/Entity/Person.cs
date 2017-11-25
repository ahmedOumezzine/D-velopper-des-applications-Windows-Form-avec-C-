using DotNetTN.Connector.SQL.Mapping;

namespace DemoApplication.Entity
{
    [Table("Person")]
    public class Person
    {
        [Column(IsPrimaryKey = true, IsIdentity = true, ColumnName = "PersonID")]
        public int Id { get; set; }

        [Column(ColumnName = "Name")]
        public string Name { get; set; }

        [Column(ColumnName = "Prenom")]
        public string Prenom { get; set; }

        [Column(ColumnName = "Ville")]
        public string Ville { get; set; }
    }
}