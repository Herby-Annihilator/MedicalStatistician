using MedicalStatistician.DAL.Entities.Base;

namespace MedicalStatistician.DataStorage
{
    public class Storage<T> where T : NamedEntity
    {        
        private static Storage<T> _storage = new();
        private Storage() { }
        public static Storage<T> Instance() => _storage;
        public string Name { get; set; }
        public ICollection<T> Collection { get; set; }


    }

}
