using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.Domain;
using Core.Domain.ViewModels.ItemType;
using Core.Service;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace OnionArchitecture.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ItemTypesController : ControllerBase
    {
        public readonly IService<ItemType, CreateItemType> service;
        public ItemTypesController(IService<ItemType, CreateItemType> service_)
        {
            service = service_;
        }
        [HttpGet]
        public ActionResult ItemTypes()
        {
            var Rs = service.GetAll();
            return Ok(Rs);
        }
        [HttpPost]
        public ActionResult CreateItemType(CreateItemType itemType)
        {
            var Rs = service.Create(itemType);
            return Ok(Rs);
        }
    }
}