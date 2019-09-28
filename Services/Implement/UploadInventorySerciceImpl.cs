using inventory_api.Dto;
using inventory_api.Helpers;
using inventory_api.Services.Strategies;
using inventory_api.Services.Strategies.Concretes;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace inventory_api.Services.Implement
{
    public class UploadInventorySerciceImpl : IUploadInventoryService
    {
        public InventoryDTO classify(IFormFile formFile)
        {
            Context context;
            //Obtenemos los animales del archivo
            var fileSystemHelper = new FileSystemHelper();
            var animals = fileSystemHelper.getAll(formFile);
            //Clasificamos los animales segun corresponda
            //Seleccionamos la estrategia que necesitamos en este momento
            /*
             * Creamos una estrategia debido al requisito de poder cambiar la implementacion
             * o la manera de clasificar los animales
             */
            context = new Context(new ClassifyConcreteDefault());
            var inventory=context.ContextInterface(animals);
            //Guardamos el inventario distribuido
            fileSystemHelper.createFile(inventory.Bovinos,"Bovinos");
            fileSystemHelper.createFile(inventory.Equinos, "Equinos");
            //retornamos resultado
            return inventory;

        }
    }
}
