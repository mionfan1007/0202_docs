namespace docum_dll
{
    public class ListMethods<T>
    {

        public List<T> values = new List<T>();
        public List<T> GetList() { return values; }
        public T AddElement(T element)
        {
            try
            {
                values.Add(element);
                return (T)element;
            }
            catch
            {
                throw;
            }

        }
        public T RemoveElement(T element)
        {
            try
            {
                values.Remove(element);
                return (T)element;
            }
            catch { throw; }

        }
        public T SearchElement(T element)
        {
            try
            {
                foreach (T value in values)
                {
                    if (EqualityComparer<T>.Default.Equals(value, element))
                    {
                        return value;

                    }
                    else { return default(T); }

                }
                return default(T);
            }
            catch { throw; }
        }
    }
}
