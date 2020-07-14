using LipraryMVP.Logic.Services;
using LipraryMVP.Models;
using LipraryMVP.Views.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LipraryMVP.Views.Forms;

namespace LipraryMVP.Logic.Presenter
{
    class CategoryPresenter
    {
        ICategory icategory;
        CategoryModel catModel = new CategoryModel();
      //  private Frm_Category frm_Category;

        public CategoryPresenter(ICategory view)
        {
            this.icategory = view;
        }

        //public CategoryPresenter(Frm_Category frm_Category)
        //{
        //    this.frm_Category = frm_Category;
        //}

        private void connectBetweenModel_and_Interface()
        {
            catModel.ID      = icategory.ID;
            catModel.CatName = icategory.CatName;
        }

        public bool Catinsert()
        {
            connectBetweenModel_and_Interface();
            return CategoryService.categoryInsert(catModel.ID ,catModel.CatName);
        }
    }
}
