﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace university_online_assessment.Views.Student
{
    public partial class StudentViewList : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnViewAsmnt_Click(object sender, EventArgs e)
        {
            Response.Redirect("/student/assessment");
        }
    }
}