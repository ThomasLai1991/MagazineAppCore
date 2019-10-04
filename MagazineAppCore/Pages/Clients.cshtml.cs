using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MagazineAppContext;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using MagazineAppContext.Models;

namespace MagazineAppCore.Pages
{
    public class ClientsModel : PageModel
    {
        public MagazineAppContext.Context _context;

        public ClientsModel(MagazineAppContext.Context Context)
        {
            _context = Context;
        }

        public List<MagazineAppContext.Models.client_cln_list> Clients;

        public int UserID = 1; // need to be change
        public int MagazineID = 1;
        public string CurrentFilter="";

        public int Count;
        public bool PreviousPage;
        public bool NextPage;
        public int PageIndex;
        public int TotalPage;
        public int PageResultCount;


        // string CurrentFilter , int resultPerPage=50,int pageIndex=1,int UserID=1,int MagazineID=1,string SearchText=""
        public void OnGet(string currentFilter, int pageIndex,int pageSize=50, string seachText = "")
        {
            //create filter
            var filter = new CFilters();
            filter.UserID = UserID;
            filter.MagazineID = MagazineID;
            if (seachText != null)
            {
                pageIndex = 1;
                filter.SearchText = seachText;
            }
            else
            {
                filter.SearchText = CurrentFilter;
            }
      

            Count = _context.Model.Clients.GetCount(filter);
            //the number of results in one page, when in last page, it won't be 50;



            PageIndex = pageIndex;
            TotalPage = Count / pageSize;


            if (pageIndex == 1)
            {
                PreviousPage = false;
            }
            else
            {
                PreviousPage = true;
            }
            if (pageIndex == TotalPage)
            {
                NextPage = false;
            }
            else
            {
                NextPage = true;
            }


            //loading
            _context.Model.Clients.LoadListItems(pageSize, pageIndex, filter);
            PageResultCount = _context.Model.Clients.Count;
            Clients = _context.Model.Clients;
        }
    }
}