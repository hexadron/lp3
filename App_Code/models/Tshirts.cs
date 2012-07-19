using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

public static class Tshirts
{
    static TshirtsDataContext db = new TshirtsDataContext();

    public static tshirt create(string _name, string _description,
        DateTime _expire_time, decimal _price, string _foto = "")
    {
        tshirt shirt = new tshirt {
            name = _name,
            description = _description,
            expire_time = _expire_time,
            price = _price,
            imagen = _foto
        };

        if (validateShirt(shirt))
        {
            db.tshirts.InsertOnSubmit(shirt);
            db.SubmitChanges();
            return shirt;
        }

        return null;
    }

    private static bool validateShirt(tshirt shirt)
    {
        return shirt.expire_time > DateTime.Now;
    }

    public static tshirt find(int id)
    {
        return (from dshirt in db.tshirts
                where dshirt.id == id
                select dshirt).Single();
    }

    public static List<tshirt> all()
    {
        return (from s in db.tshirts
                select s).ToList();
    }

    public static List<tshirt> not_expired()
    {
        return (from s in db.tshirts
                where s.expire_time > DateTime.Now.Date
                select s).ToList();
    }

    public static void delete(int id)
    {
        var shirt = (from dshirt in db.tshirts
            where dshirt.id == id
        select dshirt).Single();

        db.tshirts.DeleteOnSubmit(shirt);
        db.SubmitChanges();
    }

    public static bool update(int id, string _name, string _description,
        DateTime _expire_time, decimal _price, string _foto = "")
    {
        var shirt = (from dshirt in db.tshirts
                     where dshirt.id == id
                     select dshirt).Single();

        shirt.name = _name;
        shirt.description = _description;
        shirt.expire_time = _expire_time;
        shirt.price = _price;
        shirt.imagen = _foto;

        db.SubmitChanges();

        return true;
    }
}