using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAssgn.AssignModel;

namespace WebAssgn.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MenuController : ControllerBase
    {
        public  chaatsContext db=new chaatsContext();
        
       
        

        [HttpGet]
        public async Task<IActionResult> Getchaats()
        {
            return Ok(await db.Chaats.ToListAsync());
        }
        [HttpPost]
        public async Task<IActionResult> AddChaat(Chaat C)
        {
            db.Chaats.Add(C);
            await db.SaveChangesAsync();
            return Ok();
        }

        [HttpPut]
        public async Task<IActionResult> UpdateEmployee(int id, Chaat C
            )
        {

            db.Entry(C).State = EntityState.Modified;
            await db.SaveChangesAsync();
            return Ok();
        }
        [HttpDelete]
        public async Task<IActionResult> DeleteChaat(int Cid)
        {
            Chaat C = db.Chaats.Find(Cid);
            db.Chaats.Remove(C);
            await db.SaveChangesAsync();
            return Ok();
        }

        [HttpGet]
        [Route("drinks")]
        public async Task<IActionResult> Getdrinks()
        {
            return Ok(await db.Drinks.ToListAsync());
        }

        [HttpPost]
        [Route("drinks")]
        public async Task<IActionResult> AddDrink(Drink d)
        {
            db.Drinks.Add(d);
            await db.SaveChangesAsync();
            return Ok();
        }
        [HttpPut]
        [Route("drinks")]
        public async Task<IActionResult> UpdateDrink(int id, Drink d)
        {

            db.Entry(d).State = EntityState.Modified;
            await db.SaveChangesAsync();
            return Ok();
        }
        [HttpDelete]
        [Route("drinks")]
        public async Task<IActionResult> DeleteEmployee(int id)
        {
            Drink d = db.Drinks.Find(id);
            db.Drinks.Remove(d);
            await db.SaveChangesAsync();
            return Ok();

        }
    }
}
