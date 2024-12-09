namespace Lesson1.Models
{
	public class CateringEstablishment
	{
		public int Id { get; set; }
		private static int nextId = 0;
		public string? Name { get; set; }
		public string? Place {  get; set; }
		public int Grade { get; set; }
		public CateringEstablishment()
		{
			Id = nextId++;
		}
	}
}
