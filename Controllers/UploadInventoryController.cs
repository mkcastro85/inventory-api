using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using inventory_api.Dto;
using inventory_api.Exceptions;
using inventory_api.Services;
using inventory_api.Services.Implement;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace inventory_api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UploadInventoryController : ControllerBase
    {
        private IUploadInventoryService inventoryService;

        public UploadInventoryController()
        {
            inventoryService = new UploadInventorySerciceImpl();
        }

        [HttpPost, DisableRequestSizeLimit]
        public InventoryDTO UploadFile()
        {
            return inventoryService.classify(Request.Form.Files[0]);
        }
    }
}
