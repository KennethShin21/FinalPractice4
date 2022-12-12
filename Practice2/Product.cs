namespace Practice2
{
    public class Products
    {
        private string _productName = "";
        private string _productID = "";
        private int _productQuantity;
        private double _productPrice = 0.00; 

        public Products()
        {

        }
        
        public string GetProductDetail()
        {
            return $"{_productID} {_productName} {_productPrice} {_productQuantity}";
        }

        public void SetProductID(string newProductID)
        {
            _productID = newProductID;
        }

        public string GetProductID()
        {
            return _productID;
        }

        public void SetProductName(string newProductName)
        {
            _productName = newProductName;
        }

        public string GetProductName()
        {
            return _productName;
        }

        public void SetProductPrice(double newProductPrice)
        {
            _productPrice = newProductPrice;
        }

        public double GetProductPrice()
        {
            return _productPrice;
        }
        public void SetProductQuantity(int newProductQuantity)
        {
            _productQuantity = newProductQuantity;
        }

        public double GetProductQuantity()
        {
            return _productQuantity;
        }
    }
}