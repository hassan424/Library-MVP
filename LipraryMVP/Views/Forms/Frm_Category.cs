using LipraryMVP.Logic.Presenter;
using LipraryMVP.Views.Interface;
using System;
using System.Linq;
using System.Windows.Forms;

namespace LipraryMVP.Views.Forms
{
    public partial class Frm_Category : DevExpress.XtraEditors.XtraForm , ICategory
    {
        CategoryPresenter catPresenter;

        public int ID { get => Convert.ToInt32(txt_ID.Text); set => txt_ID.Text = value.ToString(); }
        public string CatName { get => Convert.ToString(txt_Name.Text); set => txt_Name.Text = value.ToString(); }

        public Frm_Category()
        {
            InitializeComponent();
            catPresenter = new CategoryPresenter(this);
        }

        private void Frm_Category_Load(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            bool check = catPresenter.Catinsert();
            if (check)
            {
             MessageBox.Show("تمت الاضافة بنجاح" , "تاكيد" ,MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("لم تتم الاضافة", "تحدير", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}