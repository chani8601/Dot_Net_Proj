namespace DO;

[Serializable]
public class DalAlreadyExistsException : Exception
{
    public DalAlreadyExistsException(string entityName, int id)
        : base($"{entityName} עם ID {id} כבר קיים במערכת") { }
}
[Serializable]
public class DalNotFoundException : Exception
{
    public DalNotFoundException(string entityName, int id)
        : base($"{entityName} עם ID {id} אינו קיים במערכת") { }
}
