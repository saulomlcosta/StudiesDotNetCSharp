using System;
using System.Web.UI.WebControls;
using ContosoUniversityModelBinding.Models;

namespace ContosoUniversityModelBinding
{
    public partial class MyStudent : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        public void addStudentForm_InsertItem()
        {
            var item = new Models.Student();
            TryUpdateModel(item);
            if (ModelState.IsValid)
            {
                using (SchoolContext db = new SchoolContext())
                {
                    db.Students.Add(item);
                    db.SaveChanges();
                }

            }
        }

        protected void cancelButton_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Student");
        }

        protected void addStudentForm_ItemInserted(object sender, FormViewInsertedEventArgs e)
        {
            Response.Redirect("~/Student");
        }
    }
}