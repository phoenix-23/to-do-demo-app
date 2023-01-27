namespace ToDo.Data.Models
{
	public class Work
	{
		public int Id { get; set; }
		public string Name { get; set; }
		public string? Description { get; set; }
		public DateTime TimeCreated { get; set; }
		public DateTime TimeLastUpdated { get; set; }
		public bool Finished { get; set; }

	}
}
