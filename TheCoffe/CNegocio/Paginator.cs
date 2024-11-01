using System;
using System.Collections.Generic;
using System.Linq;

namespace TheCoffe.CNegocio
{

    public class Paginator<T>
    {
        private List<T> data;
        private int pageSize;

        public int CurrentPage { get; private set; }
        public int TotalPages => (int)Math.Ceiling(data.Count / (double)pageSize);

        public Paginator(List<T> data, int pageSize)
        {
            this.data = data;
            this.pageSize = pageSize;
            this.CurrentPage = 1;
        }

        public List<T> GetPageData()
        {
            return data.Skip((CurrentPage - 1) * pageSize).Take(pageSize).ToList();
        }

        public void NextPage()
        {
            if (CurrentPage < TotalPages)
                CurrentPage++;
        }

        public void PreviousPage()
        {
            if (CurrentPage > 1)
                CurrentPage--;
        }

        public void GoToPage(int pageNumber)
        {
            if (pageNumber >= 1 && pageNumber <= TotalPages)
                CurrentPage = pageNumber;
        }
    }
}
