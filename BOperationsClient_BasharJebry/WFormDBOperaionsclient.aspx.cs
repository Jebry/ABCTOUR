using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BOperationsClient_BasharJebry.ServiceReferenceDBOperations;

namespace BOperationsClient_BasharJebry
{
    public partial class WFormDBOperaionsclient : System.Web.UI.Page
    {
        TourDBOperationsService_BasharClient clientDB;
        protected void Page_Load(object sender, EventArgs e)
        {
            clientDB = new TourDBOperationsService_BasharClient("BasicHttpBinding_ITourDBOperationsService_Bashar");
            
        }

        protected void btnDelete_Click(object sender, EventArgs e)
        {
            DeleteABus bus = new DeleteABus();
            bus.BusId = Int32.Parse(txtDeleteID.Text);
           lblmsg.Text= clientDB.DeleteABus(bus);


        }

        protected void btnInsert_Click(object sender, EventArgs e)
        {
            InsertABus bus = new InsertABus();
            bus.BusId = Int32.Parse(txtInsertID.Text);
            bus.Make = txtInsertMake.Text;
            bus.Model = txtInsertModel.Text;
            bus.NoOfSeats = Int32.Parse(txtInsertNoOfSeat.Text);
            lblmsg.Text=clientDB.InsertABus(bus);



        }

        protected void btnUpdate_Click(object sender, EventArgs e)
        {
            UpdateABus updatedInfo = new UpdateABus();
            updatedInfo.BusId =Int32.Parse(txtUpdateID.Text);
            updatedInfo.Make = txtUpdateMake.Text;
            updatedInfo.Model = txtUpdateModel.Text;
            updatedInfo.NoOfSeats = Int32.Parse(txtUpdateNoOfSeat.Text);
            lblmsg.Text = clientDB.UpdateABus(updatedInfo);

        }

        protected void btnRetrieveData_Click(object sender, EventArgs e)
        {
            Response.Redirect("WFormRetrieveDataClient.aspx");
        }
    }
}