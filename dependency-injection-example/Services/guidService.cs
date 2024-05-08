namespace dependency_injection_example.Services
{
    /// <summary>
    /// Interface name to be used for Singleton setup
    /// </summary>
    public interface IGuidSingleton
    {
        Guid Value();
    }

    /// <summary>
    /// Interface name to be used for Scoped setup
    /// </summary>
    public interface IGuidScoped
    {
        Guid Value();
    }

    /// <summary>
    /// Interface name to be used for Transient setup
    /// </summary>
    public interface IGuidTransient
    {
        Guid Value();
    }


    /// <summary>
    /// Create a new guid when the class is initialized. Call the Value method to return the guid value
    /// </summary>
    public class guidService : IGuidSingleton, IGuidScoped, IGuidTransient
    {
        private Guid _guid = Guid.NewGuid();

        public Guid Value() => _guid;

    }
}
