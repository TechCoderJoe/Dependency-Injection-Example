namespace dependency_injection_example.Models
{
    public class guidServicesModel
    {
        public Guid guidSingleton { set; get; }
        public Guid guidScoped1 { set; get; }
        public Guid guidScoped2 { set; get; }
        public Guid guidTransient1 { set; get; }
        public Guid guidTransient2 { set; get; }
    }
}
