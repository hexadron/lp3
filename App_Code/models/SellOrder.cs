using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Data;

/// <summary>
/// Summary description for SellOrder
/// </summary>
public class SellOrder
{
    static TshirtsDataContext db = new TshirtsDataContext();

    public static sellOrder fromCart(List<CarItem> cart)
    {
        sellOrder order = new sellOrder();
        db.sellOrders.InsertOnSubmit(order);

        db.SubmitChanges();

        int id = order.id;
        var items = new List<item>();
        decimal total = 0;

        foreach (CarItem it in cart)
        {
            item i = new item();
            i.quantity = it.qty;
            i.tshirt_id = it.shirt.id;
            i.sellOrder_id = id;

            total += (decimal)it.shirt.price * it.qty;

            items.Add(i);
        }

        order.total = total;

       // db.items.InsertAllOnSubmit(items);
        db.SubmitChanges();

        return order;
    }

    public static void save(sellOrder order)
    {
        order.ordered_at = DateTime.Now;
        db.SubmitChanges();
    }

    public static sellOrder find(int id)
    {
        return (from order in db.sellOrders
                where order.id == id
                select order).Single();
    }

    public DataTable listarOrdenes() 
    {
        SqlConnection CN = new SqlConnection("Data Source = USER-PC\\SQLEXPRESS; Initial Catalog = tshirts; Integrated Security = True");
        //SqlConnection CN = new SqlConnection(""server=.;database=tshirts;uid=sa;pwd=sql");
        
        SqlDataAdapter da = new SqlDataAdapter("select * from sellOrder",CN);
        
        //var ord = from o in db.sellOrders select o;

        DataTable dt = new DataTable();

        da.Fill(dt);
        return dt;
    }
}