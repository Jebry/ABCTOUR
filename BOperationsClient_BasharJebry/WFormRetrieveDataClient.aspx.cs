using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BOperationsClient_BasharJebry.ServiceReferenceDBOperations;

namespace BOperationsClient_BasharJebry
{
    public partial class WFormRetrieveDataClient : System.Web.UI.Page


    {
        TourDBOperationsService_BasharClient clientDB;
        protected void Page_Load(object sender, EventArgs e)
        {
            clientDB = new TourDBOperationsService_BasharClient("BasicHttpBinding_ITourDBOperationsService_Bashar");
        }

        protected void btnShow_Click(object sender, EventArgs e)
        {
            GridView1.DataSource = clientDB.RetrieveBusInfo().dataset;
            GridView1.DataBind();
        }

        protected void btnRetriveID_Click(object sender, EventArgs e)
        {
            FindABus IdData = new FindABus();
            FoundRecord foundRow = new FoundRecord();
            IdData.BusId = Int32.Parse(txtIDRetrieve.Text);
           foundRow= clientDB.FindABus(IdData);
            lblID.Text = foundRow.BusId.ToString();
            lblMake.Text = foundRow.Make;
            lblModel.Text = foundRow.Model;
            lblNoOfSeat.Text = foundRow.NoOfSeats.ToString();
        }
    }
}