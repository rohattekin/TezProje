﻿using DataAccessLayer.Concreate.Repositories;
using EntityLayer.concreate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concreate
{
    public class CategoryManager
    {

        GenericRepository<Category> repo = new GenericRepository<Category>();

        public List<Category> GetAllBL()
        {

            return (List<Category>)repo.List();

        }
        public void CategoryAddBL(Category p)
        {
            if(p.CategoryName=="" || p.CategoryName.Length<=3|| p.CategoryDescription==""|
                p.CategoryName.Length >= 51)
            {
                // hata mesajı
            }
            else
            {
                repo.Insert(p);
            }
        }

    }
}
