using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for CarItem
/// </summary>
public class CarItem
{
    public int shirt { get; set; }
    public int qty { get; set; }

	public CarItem(int shirt)
	{
        this.shirt = shirt;
	}

    public int add(int qty)
    {
        return this.qty += qty;
    }
}