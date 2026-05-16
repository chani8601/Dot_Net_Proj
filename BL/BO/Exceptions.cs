
namespace BL.BO
{

    [Serializable]
    public class BLAlreadyExistsException : Exception
    {
        public BLAlreadyExistsException(string entityName)
            : base(entityName){ }
        public BLAlreadyExistsException(string entityName ,Exception innerException)
            : base(entityName, innerException) { }
    }
    [Serializable]
    public class BlNotFoundException : Exception
    {
        public BlNotFoundException(string entityName)
            : base(entityName) { }

        public BlNotFoundException(string entityName, Exception innerException)
            : base(entityName, innerException) { }
    }












}
