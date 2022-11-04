namespace SportsSchedule.Web.Areas.Administration.Controllers
{
    using SportsSchedule.Common;
    using SportsSchedule.Web.Controllers;

    using Microsoft.AspNetCore.Authorization;
    using Microsoft.AspNetCore.Mvc;

    [Authorize(Roles = GlobalConstants.AdministratorRoleName)]
    [Area("Administration")]
    public class AdministrationController : BaseController
    {
    }
}
