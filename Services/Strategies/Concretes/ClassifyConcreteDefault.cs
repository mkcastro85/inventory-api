using inventory_api.Dto;
using inventory_api.Exceptions;
using Microsoft.EntityFrameworkCore.Internal;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace inventory_api.Services.Strategies.Concretes
{
    //Estrategia concreta para cuando se quiere validar que los Bobinos empiecen por "b"
    public class ClassifyConcreteDefault : IStrategyClassify
    {
        //Clasificacion de animales por inicio de primer caracter con "b"
        public InventoryDTO classify(List<string> animals)
        {
            try
            {
                var Bovinos = new List<string>();
                var Equinos = new List<string>();

                //Recorremos los animales del inventario
                foreach (var animal in animals)
                {
                    //Validamos si empiezan por "b" son bovinos
                    if (animal.StartsWith("b"))
                    {
                        Bovinos.Add(animal);
                    }
                    else
                    {
                        Equinos.Add(animal);
                    }
                }

                //Armamos el inventario distribuido
                var inventory = new InventoryDTO();
                inventory.Bovinos = Bovinos;
                inventory.Equinos = Equinos;

                return inventory;
            }
            catch(System.Exception ex)
            {
                throw new InventoryException("Error clasificando el inventario "+ ex.Message);
            }
            
        }
    }
}
