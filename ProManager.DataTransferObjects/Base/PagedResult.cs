﻿using System.Collections.Generic;

namespace ProManager.DataTransferObjects.Base
{
    public class PagedResult<T>
    {
        public IList<T> Results { get; set; }
        public int CurrentPage { get; set; }
        public int PageCount { get; set; }
        public int PageSize { get; set; }
        public int RowCount { get; set; }
        public dynamic Extras { get; set; }
    }
}
