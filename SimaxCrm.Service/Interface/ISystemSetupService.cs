using SimaxCrm.Model.Entity;
using System.Collections.Generic;

namespace SimaxCrm.Service.Interface
{
    public interface ISystemSetupService
    {
        List<SystemSetup> List();
        SystemSetup ById(int id);
        void Create(SystemSetup serviceType);
        void Update(SystemSetup serviceType);
        void Delete(int id);
    }
}
