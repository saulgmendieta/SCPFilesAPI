using System.ComponentModel.DataAnnotations;

namespace SCPFilesAPI.Entities
{
    public class IncidentLog
    {
        [Key]
        public int Id { get; set; }
        public virtual SCP SCP { get; set; }
        public string IncidentType { get; set; }
        public DateTime AlarmDate { get; set; }
        public int Acknowledge { get; set; }
        public string PersonnelAcked{ get; set; }
    }
}
