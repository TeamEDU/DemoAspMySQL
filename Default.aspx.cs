using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Domain;
using Session;

public partial class _Default : System.Web.UI.Page
{
    private Broker broker = new Broker();

    protected void Page_Load(object sender, EventArgs e)
    {
        FillGridView();
    }

    private void FillGridView()
    {
        GridViewName.DataSource = broker.Fill();
        GridViewName.DataBind();
    }

    protected void btnAdd_Click(object sender, EventArgs e)
    {
        Human human = new Human();
        human.Name = txtBoxName.Text;

        broker.Insert(human);

        FillGridView();
    }
}