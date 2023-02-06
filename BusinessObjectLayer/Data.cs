namespace BusinessObjectLayer;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

[Table("info")]
public class Data
{
    public int id { get; set; }
    public string topic { get; set; }
    public string loaction { get; set; }

    public string faculty { get; set; }

}
