using MedicalStatistician.DAL.Entities.Base;

namespace MedicalStatistician.DataStorage
{
    public class Storage
    {
        private static Storage _storage;
        private Storage() { }
        public static Storage Instance() => _storage ??= new Storage();
        public string Name { get; set; }
        public ICollection<NamedEntity> Entities { get; set; }


    }
}
