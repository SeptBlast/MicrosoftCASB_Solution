// 	File Name : MicrosoftCAPSController.cs
// 	Auther Name : Devesh Kumar
// 	Auther EmailId : deveshkumarsep12@outlook.com
// 	Date : 05-05-2020
//
using System;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using TodoApi.Models;
using MicrosoftCAPS.Model;

namespace MicrosoftSolution.Controller
{

    #region snippet_TodoController
    [Produces("application/json")]
    [Route("api/[controller]")]
    [ApiController]
    public class MicrosoftCAPSController : ControllerBase
    {
        private readonly MicrosoftCAPSContext _context;
        #endregion

        public MicrosoftCAPSController(MicrosoftCAPSContext context)
        {
            _context = context;
            if (_context.MicrosftCAPSItems.Count() == 0)
            {
                _context.MicrosftCAPSItems.Add(new MicrosftCAPSItems { Cloud = "Microsoft Cloud Access Data" });
                _context.SaveChanges();
            }
        }

        #region snippet_GetAll
        [HttpGet]
        public ActionResult<List<MicrosftCAPSItems>> GetAll()
        {
            return _context.MicrosftCAPSItems.ToList();
        }
        #endregion

        #region snippet_GetById
        [HttpGet ("{id}", Name = "Microsoft CASB")]
        public ActionResult<MicrosftCAPSItems> GetById(string Token, string cloudName)
        {
            var item = _context.MicrosftCAPSItems.Find(Token);
            var item_cloudName = _context.MicrosftCAPSItems.Find(cloudName);

            if (item == null && item_cloudName == null) return NotFound();

            return item;
        }
        #endregion

        #region snippet_Delete
        /// <summary>
        /// Deletes a specific TodoItem.
        /// </summary>
        /// <param name="id"></param>        
        [HttpDelete("{id}")]
        public IActionResult Delete(long id)
        {
            var todo = _context.MicrosftCAPSItems.Find(id);

            if (todo == null)
            {
                return NotFound();
            }

            _context.MicrosftCAPSItems.Remove(todo);
            _context.SaveChanges();

            return NoContent();
        }
        #endregion
    }
}