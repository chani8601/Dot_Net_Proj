namespace DalApi;
using DO;

public interface ICrud<T>
{
    int Create(T item); 
    T? Read(int id); 
    void Update(T item); 
    void Delete(int id);
    List<T?> ReadAll(Func<T, bool>? filter = null);
    T? Read(Func<T, bool> filter); 
}