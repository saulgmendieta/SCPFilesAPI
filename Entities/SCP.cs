namespace SCPFilesAPI.Entities
{
    public class SCP
    {
        public double Id { get; set; }
        public string CodeName { get; set; }
        public string Description { get; set; }
        public string Classification { get; set; }
        public string RestrictedDescription { get; set; }
        public string Image { get; set; }
        public virtual ContentionArea CellCode { get; set; }

    }
}
