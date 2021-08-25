using System;
using System.Collections.Generic;
using eShopSolution.Application.Dtos;

namespace eShopSolution.Application.Catalog.Products.Dtos.Manage
{
    public class GetManageProductPagingRequest : PagingRequestBase
    {
        public string Keyword { get; set; }

        public List<int> CategoryIds { get; set; }
    }
}
