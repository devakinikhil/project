using SimaxCrm.Model.Entity;
using System.Collections.Generic;

namespace SimaxCrm.Service.Interface
{
    public interface ICallLogService
    {
        List<CallLog> List();
        CallLog ById(int id);
        void Create(CallLog serviceType);
        void Update(CallLog serviceType);
        List<CallLog> ByInvoiceId(int invoiceId);
    }
}
