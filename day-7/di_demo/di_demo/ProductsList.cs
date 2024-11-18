namespace di_demo
{
    public class ProductsList
    {
        public int pId { get; set; }
        public string pName { get; set; }
        public string pCategory { get; set; }
        public string pDescription { get; set; }
        public double pPrice { get; set; }
        public bool pIsInStock { get; set; }

        static List<ProductsList> pList = new List<ProductsList>()
         {
             new ProductsList(){ pId=101, pName="Pepsi", pCategory="Cold-Drink", pPrice=80, pDescription="Soda Water for dry throat", pIsInStock=true},
             new ProductsList(){ pId=102, pName="Iphone", pCategory="Electronics", pPrice=80, pDescription="Soda Water for dry throat", pIsInStock=true},
             new ProductsList(){ pId=103, pName="Air-Pods", pCategory="Electronics", pPrice=80, pDescription="Soda Water for dry throat", pIsInStock=true},
             new ProductsList(){ pId=104, pName="Fossil Q", pCategory="Electronics", pPrice=80, pDescription="Soda Water for dry throat", pIsInStock=true},
             new ProductsList(){ pId=105, pName="Maggie", pCategory="Fast-Food", pPrice=80, pDescription="Soda Water for dry throat", pIsInStock=true},
         };

        public List<ProductsList> GetAllProducts()
        {
            return pList;
        }




    }
}