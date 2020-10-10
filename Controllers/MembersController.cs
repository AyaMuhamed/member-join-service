using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using MemberServices.Models;
using Swashbuckle.AspNetCore.Annotations;

namespace MemberServices.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    
    public class MembersController :ControllerBase
    {

        
        private readonly MemberContext _context;
        
        public MembersController(MemberContext member)
        {
            _context=member;
        }

        [HttpGet]
        [SwaggerOperation(Summary = "Members list",Description="This service retrieves members list. ")]
        [SwaggerResponse(200,"Ok - Success",typeof(List<Member>))]
        [SwaggerResponse(400,"Bad Request - Client needs to fix request",typeof(ProblemDetails))]
        [SwaggerResponse(401,"Unauthorized - User needs to authenticated",typeof(ProblemDetails))]
        [SwaggerResponse(403,"Forbidden - User doenn't have access to this service",typeof(ProblemDetails))]
        [SwaggerResponse(404,"Not Found - Resource doesn't exist",typeof(ProblemDetails))]
        [SwaggerResponse(500,"Internal Server Error - System or network failure",typeof(ProblemDetails))]
        [SwaggerResponse(502,"Bad Geteway - Invalid response")]
        [SwaggerResponse(503,"Service Unavailable")]

        public ActionResult<IEnumerable<Member>> getMembers() => _context.Members;

        //     [HttpGet("{Id}")]
        //     public ActionResult<Member> getMember(int Id)
        //     {
        //          Member member=_context.Members.Find(Id);
        //          if(member==null)
        //          {
        //              return NotFound();
        //          }
        //         return member;

        //    }

        //     [HttpPost]
        //     public ActionResult<string> addMember(Member member)
        //     {
        //          _context.Members.Add(member);
        //          _context.SaveChanges();

        //         return "Created";

        //     }

    }
}