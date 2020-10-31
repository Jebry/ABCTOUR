<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WFormRetrieveDataClient.aspx.cs" Inherits="BOperationsClient_BasharJebry.WFormRetrieveDataClient" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:GridView ID="GridView1" runat="server">
            </asp:GridView>
            <asp:Button ID="btnShow" runat="server" Text="Show Data" OnClick="btnShow_Click" />
            <br />
            <br />
            <asp:Label ID="EnterID" runat="server" Text="Enter ID"></asp:Label>
            <br />
           <asp:TextBox ID="txtIDRetrieve" runat="server"></asp:TextBox>
           <asp:Button ID="btnRetriveID" runat="server" Text="Show Specific Data" OnClick="btnRetriveID_Click" />            
                 <br />
           
            <asp:Label ID="lblID" runat="server" Text="Id"></asp:Label>
            <br />
            <asp:Label ID="lblMake" runat="server" Text="Make"></asp:Label>
            <br />
            <asp:Label ID="lblModel" runat="server" Text="Model"></asp:Label>
            <br />
            <asp:Label ID="lblNoOfSeat" runat="server" Text="NoOfSeat"></asp:Label>
        </div>
    </form>
</body>
</html>
