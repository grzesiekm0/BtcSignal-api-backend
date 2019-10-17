﻿using System;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using btcsignalwebservice.Model;

namespace btcsignalwebservice.Controllers
{ //test 
    [Route("api/[controller]")]
    [ApiController]
    public class AlertController : ControllerBase
    {
        private readonly AlertContext _context;

        public AlertController(AlertContext context)
        {
            _context = context;
            
        }

        // GET: api/alert test
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Alert>>> GetAlerts()
        {
            return await _context.Alerts.ToListAsync();
        }

        // GET: api/Todo/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Alert>> GetAlert(long id)
        {
            var todoItem = await _context.Alerts.FindAsync(id);

            if (todoItem == null)
            {
                return NotFound();
            }

            return todoItem;
        }


        // POST: api/Todo
        [HttpPost]
        public async Task<ActionResult<Alert>> PostAlert(Alert item)
        {
            _context.Alerts.Add(item);
            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(GetAlert), new { id = item.AlertId }, item);
        }

        // PUT: api/Todo/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutAlert(long id, Alert item)
        {
            if (id != item.AlertId)
            {
                return BadRequest();
            }

            _context.Entry(item).State = EntityState.Modified;
            await _context.SaveChangesAsync();

            return NoContent();  
        }

        // DELETE: api/Todo/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteAlert(long id)
        {
            var todoItem = await _context.Alerts.FindAsync(id);

            if (todoItem == null)
            {
                return NotFound();
            }

            _context.Alerts.Remove(todoItem);
            await _context.SaveChangesAsync();

            return NoContent();
        }

    }
}
