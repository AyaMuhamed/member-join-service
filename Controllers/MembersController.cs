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

        
        [HttpPost]
        public ActionResult<Member> addMember(Member member)
        {
             _context.Members.Add(member);
             _context.SaveChanges();

            return CreatedAtAction("getMember",new Member{id=member.id},member);
          
        }

    }
}