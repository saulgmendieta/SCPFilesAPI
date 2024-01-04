using System.ComponentModel.DataAnnotations;

namespace SCPFilesAPI.Entities
{
    public class ContentionArea
    {
        [Key]
        public string CellCode { get; set; }
        public int Floor { get; set;}
        public int Area { get; set;}
        public double Size { get; set;}

    }
}
