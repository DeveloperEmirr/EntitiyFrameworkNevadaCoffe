using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class ProductManager : IProductService
    {
        IProcutDal _productDal;

        public ProductManager(IProcutDal productDal)
        {
            _productDal = productDal;
        }

        public List<Product> Getall()
        {
            return _productDal.GetAll();
        }
    }
}
