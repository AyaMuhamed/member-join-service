using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using MemberServices.Models;

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
        public ActionResult<IEnumerable<Member>> getMembers()
        {
             
            return _context.Members;
          
        }
 
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