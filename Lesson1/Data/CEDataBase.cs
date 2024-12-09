using Lesson1.Models;

namespace Lesson1.Data
{
	public class CEDataBase : IDataBase<CateringEstablishment>
	{
		private readonly List<CateringEstablishment> _catering;

		public CEDataBase()
		{
			_catering = new List<CateringEstablishment>();
		}


		public void Add(CateringEstablishment item)
		{
			_catering.Add(item);
		}

		public IEnumerable<CateringEstablishment> Get()
		{
			return _catering;
		}

		public void Remove(CateringEstablishment car)
		{
			_catering.RemoveAll(x => x.Id == car.Id);
		}

		public void Update(CateringEstablishment oldCar, CateringEstablishment newCar)
		{
			int index = _catering.FindIndex(x => x.Id == oldCar.Id);
			_catering[index] = newCar;
		}
	}
}
