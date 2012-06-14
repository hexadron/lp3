using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;

public class Sizes
{
    TshirtsDataContext db = new TshirtsDataContext();
    
    // hay que buscar la forma de hacer seleccion
    // para eso de "tallas disponibles" que deben
    // tener los productos. Aqui estan las tallas,
    // y hay un metodo en la clase Tshirts que
    // crea la combinacion (tshirt, talla, genero).
    
    public List<size> all()
    {
        return (from s in db.sizes
            select s).ToList();
    }


    public Sizes()
    {
        // TODO: Complete member initialization
    }
}