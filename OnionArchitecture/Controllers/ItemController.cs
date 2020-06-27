using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.Domain;
using Core.Domain.ViewModels.Item;
using Core.Service;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace OnionArchitecture.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ItemController : ControllerBase
    {
        public readonly IService<Item, CreateItem> service;
        public ItemController(IService<Item, CreateItem> service_)
        {
            service = service_;
        }
        [HttpPost]
        public ActionResult CreateItem(CreateItem item)
        {
            var Rs = service.Create(item);
            return Ok(Rs);
        }
        [HttpDelete("{id}")]
        public ActionResult DeleteItem(int id)
        {
            var Rs = service.Delete(id);
            return Ok(Rs);
        }
    }
}