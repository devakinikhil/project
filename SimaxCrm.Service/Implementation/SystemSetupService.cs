using SimaxCrm.Data.Repository.Interface;
using SimaxCrm.Model.Entity;
using SimaxCrm.Service.Interface;
using System;
using System.Collections.Generic;
using System.Linq;

namespace SimaxCrm.Service.Implementation
{
    public class SystemSetupService : ISystemSetupService
    {
        private readonly ISystemSetupRepository _systemSetupRepository;
        public SystemSetupService(ISystemSetupRepository systemSetupRepository)
        {
            _systemSetupRepository = systemSetupRepository;
        }

        public void Create(SystemSetup systemSetup)
        {
            _systemSetupRepository.Insert(systemSetup);
        }

        public void Delete(int id)
        {
            var obj = _systemSetupRepository.SearchFor(x => x.Id == id).FirstOrDefault();
            obj.UpdatedDate = DateTime.Now;
            obj.Status = false;
            _systemSetupRepository.UpdateEntity(obj);
        }

        public void Update(SystemSetup systemSetup)
        {
            _systemSetupRepository.UpdateEntity(systemSetup);
        }

        public List<SystemSetup> List()
        {
            return _systemSetupRepository.SearchFor(m => m.Status).OrderByDescending(x => x.Id).ToList();
        }

        public SystemSetup ById(int id)
        {
            return _systemSetupRepository.SearchFor(x => x.Id == id).FirstOrDefault();
        }
    }
}
