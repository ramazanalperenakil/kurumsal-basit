using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class blog : System.Web.UI.Page
{
    rehber kod = new rehber();

    

    protected void Page_Load(object sender, EventArgs e)
    {
       
        RepeaterBlogUst.DataSource = kod.GetDataTable("SELECT *  FROM [blog] WHERE [Blog_Id]= 1 ");
        RepeaterBlogUst.DataBind();

        
    }
}