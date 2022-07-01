using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using OptimizedConnection;
using System;
using System.Linq;
using System.Security.Claims;

namespace SimaxCrm.Controllers
{
    [Authorize]
    public class BaseController : Controller
    {
        public int getTidFromClaim()
        {
            var claims = User.Claims.GetClaimList(System.Reflection.Assembly.GetExecutingAssembly().FullName, this.Request);
            var objTid = claims.Where(c => c.Type == "Tid").FirstOrDefault();
            if (objTid != null)
            {
                return int.Parse(objTid.Value);
            }
            return 0;
        }

        public Guid? getUidFromClaim()
        {
            var objTid = User.Claims.Where(c => c.Type == ClaimTypes.NameIdentifier).FirstOrDefault();
            if (objTid != null)
            {
                return Guid.Parse(objTid.Value);
            }
            return null;
        }

        public string getNameFromClaim()
        {
            var objTid = User.Claims.Where(c => c.Type == ClaimTypes.Name).FirstOrDefault();
            if (objTid != null)
            {
                return objTid.Value;
            }
            return null;
        }
    }
}
