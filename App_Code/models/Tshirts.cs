using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

public static class Tshirts
{
    static TshirtsDataContext db = new TshirtsDataContext();

    public static detailedTshirt addSizeAndGenre(tshirt shirt, string genre,
        int _size_id, int _stock)
    {
        detailedTshirt det = new detailedTshirt
        {
            genre = genre,
            tshirt_id = shirt.id,
            size_id = _size_id,
            stock = _stock
        };

        if (validateDshirt(det))
        {
            db.detailedTshirts.InsertOnSubmit(det);
            db.SubmitChanges();
            return det;
        }

        return null;
    }

    public static tshirt create(string _name, string _description,
        DateTime _expire_time, decimal _price)
    {
        tshirt shirt = new tshirt {
            name = _name,
            description = _description,
            expire_time = _expire_time,
            price = _price
        };

        if (validateShirt(shirt))
        {
            db.tshirts.InsertOnSubmit(shirt);
            db.SubmitChanges();
            return shirt;
        }

        return null;
    }

    public static List<detailedTshirt> variations(tshirt shirt)
    {
        return (from dshirt in db.detailedTshirts
                where dshirt.tshirt_id == shirt.id
                select dshirt).ToList();
    }

    private static bool validateDshirt(detailedTshirt det)
    {
        return det.genre == "M" || det.genre == "F";
    }

    private static bool validateShirt(tshirt shirt)
    {
        return shirt.expire_time < DateTime.Now;
    }

    public static List<tshirt> all()
    {
        return (from s in db.tshirts
                select s).ToList();
    }
}