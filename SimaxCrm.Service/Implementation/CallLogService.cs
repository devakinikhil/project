using SimaxCrm.Data.Repository.Interface;
using SimaxCrm.Model.Entity;
using SimaxCrm.Service.Interface;
using System.Collections.Generic;
using System.Linq;

namespace SimaxCrm.Service.Implementation
{
    public class CallLogService : ICallLogService
    {
        private readonly ICallLogRepository _callLogRepository;
        public CallLogService(ICallLogRepository callLogRepository)
        {
            _callLogRepository = callLogRepository;
        }

        public void Create(CallLog callLog)
        {
            _callLogRepository.Insert(callLog);
        }

        public void Update(CallLog callLog)
        {
            _callLogRepository.UpdateEntity(callLog);
        }

        public List<CallLog> List()
        {
            return _callLogRepository.SearchFor().OrderByDescending(x => x.Id).ToList();
        }

        public CallLog ById(int id)
        {
            return _callLogRepository.SearchFor(x => x.Id == id).FirstOrDefault();
        }

        public List<CallLog> ByInvoiceId(int invoiceId)
        {
            return _callLogRepository.SearchFor(x => x.InvoiceId == invoiceId).ToList();
        }
    }
}
