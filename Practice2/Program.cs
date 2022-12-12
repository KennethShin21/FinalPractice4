using System;

namespace Practice2
{
    class Program
    {
        //string shippingLabel = "";
        static void Main(string[] args)
        {
            //Make a list of orders
            List<Order> orderList = new List<Order>();
            
            //Make 5 products. 
            Products product1 = new Products();
            product1.SetProductName("Monitor");
            product1.SetProductPrice(250);
            product1.SetProductID("AE-6789");
            product1.SetProductQuantity(1);
            
            Products product2 = new Products();
            product2.SetProductName("System Unit");
            product2.SetProductPrice(300);
            product2.SetProductID("XT-7890");
            product2.SetProductQuantity(1);     

            Products product3 = new Products();
            product3.SetProductName("Hard Disk Drive");
            product3.SetProductPrice(460);
            product3.SetProductID("ZR-0987");
            product3.SetProductQuantity(1);     

            Products product4 = new Products();
            product4.SetProductName("Solid State Drive");
            product4.SetProductPrice(524);
            product4.SetProductID("MH-9653");
            product4.SetProductQuantity(1);

            Products product5 = new Products();
            product5.SetProductName("Hard Disk Drive");
            product5.SetProductPrice(460);
            product5.SetProductID("ZR-0987");
            product5.SetProductQuantity(1);

            Products USAShippingFee = new Products();
            USAShippingFee.SetProductName("USA Shipping Fee");
            USAShippingFee.SetProductPrice(5);
            USAShippingFee.SetProductID("USShipping");
            USAShippingFee.SetProductQuantity(1);

            Products notUSAShippingFee = new Products();
            notUSAShippingFee.SetProductName("Not USA Shipping Fee");
            notUSAShippingFee.SetProductPrice(35);
            notUSAShippingFee.SetProductID("notUSShipping");
            notUSAShippingFee.SetProductQuantity(1);

            //Make 2 customer's addresses
            Address customer1 = new Address();
            customer1.SetAddress("345 Livington St.","Rexburg","Idaho","USA");
            Address customer2 = new Address();
            customer2.SetAddress("348 Andres Bonifacio St.","Diffun","Quirino","Philippines");
            
            //Make orders for each customers and set the customer name, order number and order address. 
            Order order1 = new Order();            
            order1.SetCustomerName("Junior Germain");
            order1.SetOrderNo(2588963);
            order1.SetOrderAddress(customer1);

            //Add products to order products list
            order1.AddOrderLine(product1);
            order1.AddOrderLine(product3);
            order1.AddOrderLine(product5);

            Order order2 = new Order();
            order2.SetCustomerName("Arvee Valdez");
            order2.SetOrderNo(5789963);
            order2.SetOrderAddress(customer2);

            //Add products to order products list
            order2.AddOrderLine(product2);
            order2.AddOrderLine(product4);                       

            //Add orders to the orderlist
            orderList.Add(order1);
            orderList.Add(order2);

            //Print all the orders in the list.
            foreach (Order order in orderList)
            {
                Address orderAddress = order.GetOrderAddress();
                if (orderAddress.USAorNot() == true)
                {
                    order.AddOrderLine(USAShippingFee);
                }
                else
                {
                    order.AddOrderLine(notUSAShippingFee);
                }

                string thisPackingList = order.PrintPacking();
                Console.WriteLine(thisPackingList);
                Console.WriteLine();

                string thisShippingLabel = order.PrintShipping();
                Console.WriteLine(thisShippingLabel);
                Console.WriteLine("=======================================");

            }            
        }
    }
}