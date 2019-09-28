using inventory_api.Dto;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace inventory_api.Services
{
    //Interface encargada de clasificar los animales segun corresponda
    interface IUploadInventoryService
    {
        //Metodo encargado de claseificar los animales segun corresponda
        InventoryDTO classify(IFormFile formFile);
    }
}
