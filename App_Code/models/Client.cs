using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for Client
/// </summary>
public class Client
{
    static TshirtsDataContext db = new TshirtsDataContext();

    public static client create(string _email, string _password)
    {
        client cli = new client
        {
            email = _email,
            password = _password,
            is_admin = false
        };

        if (validateClient(cli))
        {
            db.clients.InsertOnSubmit(cli);
            db.SubmitChanges();
            return cli;
        }

        return null;
    }

    private static bool validateClient(client cli)
    {
        return cli.email != "" && cli.password != "" && isUnique(cli);
    }

    private static bool isUnique(client cli)
    {
        return (from c in db.clients
                where c.email == cli.email
                select c.id).Count() == 0;
    }

    public static client authenticate(string email, string password)
    {
        return (from cli in db.clients
                where cli.email == email && cli.password == password
                select cli).Single();
        
    }
}