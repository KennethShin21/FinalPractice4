namespace Practice2
{
    public class Order
    {
        private int _orderNumber;
        private string _customerName;
        public List<Products> _product = new List<Products>();
        private Address _orderAddress;

        public Order()
        {

        }        

        internal void SetOrderAddress(Address orderAddress)
        {
            _orderAddress = orderAddress;
        }

        internal Address GetOrderAddress()
        {
            return _orderAddress;
        }

        //This method will print the Packing Label of each products that contains the product quantity, product ID, product name
        //total quantity cost.
        public string PrintPacking()
        {
            double totalCost = 0.00;
            string packingString = "-----------Packing List-----------" + Environment.NewLine;
            packingString += $"{this._customerName} / Order No: {this._orderNumber}" + Environment.NewLine;
            foreach (Products product in this._product)
            {
                double productPrice = product.GetProductPrice();
                double productQuantity = product.GetProductQuantity();
                string productID = product.GetProductID();
                string productName = product.GetProductName();
                double totalQuantityCost = productPrice * productQuantity;
                totalCost += totalQuantityCost;
                packingString += $"({productQuantity}) {productID}: {productName} ${totalQuantityCost.ToString()}" + Environment.NewLine;
            }
            packingString += $"Total: ${totalCost.ToString("0.00")}";
            return packingString;          
        }

        //This method will print the Shipping Label that contains customer name, and customer's address.
        public string PrintShipping()
        {
            string shippingString = "-----------Address Label-----------" + Environment.NewLine;
            shippingString += $"{this._customerName}" + Environment.NewLine;
            shippingString += _orderAddress.getFullAddress() + Environment.NewLine;

            return shippingString;
        }

        public void SetOrderNo(int orderNumber)
        {
            _orderNumber = orderNumber;
        }
        public void SetCustomerName(string customerName)
        {
            _customerName = customerName;
        }
        public void AddOrderLine(Products product)
        {
            _product.Add(product);
        }
        public List<Products> GetProduct()
        {
            return _product;
        }
    }
}