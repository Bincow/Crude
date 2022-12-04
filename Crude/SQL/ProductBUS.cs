using Crude.Entity;

namespace Crude.SQL
{
    public class ProductBUS
    {
        ProductDAO dao = new ProductDAO();




        public ProductEntity GetProductById (long productid)
        {
            try
            {
                return dao.GetProductById (productid);
            }
            catch(Exception ex) 
            {
                throw ex;
            }

        }




    }
}
