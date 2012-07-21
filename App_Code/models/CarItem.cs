using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for CarItem
/// </summary>
public class CarItem
{
    public int qty { get; set; }
    public tshirt shirt { get; set; } 

	public CarItem(int shirt)
	{
        this.shirt = Tshirts.find(shirt);
        this.qty = 1;
	}

    public int add(int qty)
    {
        return this.qty += qty;
    }
}