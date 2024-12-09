namespace Lesson1.Data
{
	public interface IDataBase<T>
	{
		IEnumerable<T> Get();
		void Add(T item);
		void Update(T oldItem, T newItem);
		void Remove(T item);
	}
}
