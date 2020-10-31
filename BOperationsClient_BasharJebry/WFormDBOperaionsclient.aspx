<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WFormDBOperaionsclient.aspx.cs" Inherits="BOperationsClient_BasharJebry.WFormDBOperaionsclient" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        #form1 {
            height: 400px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <asp:Label ID="lblmsg" runat="server" Text="Show the result"></asp:Label>
        <br />
        <br />
        <asp:Label ID="Label1" runat="server" Text="ID"></asp:Label>
        <br />
        <asp:TextBox ID="txtDeleteID" runat="server"></asp:TextBox>
        <br />
        <br />
         <asp:Button ID="btnDelete" runat="server" Text="Delete" OnClick="btnDelete_Click" />
        <br />
        <br />
        <br />

                <asp:Label ID="Label2" runat="server" Text="ID"></asp:Label><asp:TextBox ID="txtInsertID" runat="server"></asp:TextBox>
                <asp:Label ID="Label3" runat="server" Text="Model"></asp:Label><asp:TextBox ID="txtInsertModel" runat="server"></asp:TextBox>
               <asp:Label ID="Label4" runat="server" Text="Make"></asp:Label><asp:TextBox ID="txtInsertMake" runat="server"></asp:TextBox>
               <asp:Label ID="Label5" runat="server" Text="No OF Seats"></asp:Label><asp:TextBox ID="txtInsertNoOfSeat" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Button ID="btnInsert" runat="server" Text="Insert" OnClick="btnInsert_Click" />

        <br />
        <br />
        <br />

       
         <asp:Label ID="Label6" runat="server" Text="ID"></asp:Label><asp:TextBox ID="txtUpdateID" runat="server"></asp:TextBox>
         <asp:Label ID="Label7" runat="server" Text="Model"></asp:Label><asp:TextBox ID="txtUpdateModel" runat="server"></asp:TextBox>
         <asp:Label ID="Label8" runat="server" Text="Make"></asp:Label><asp:TextBox ID="txtUpdateMake" runat="server"></asp:TextBox>
         <asp:Label ID="Label9" runat="server" Text="No Of Seat"></asp:Label><asp:TextBox ID="txtUpdateNoOfSeat" runat="server"></asp:TextBox>
        <br />
        <br />
        <br />
        <asp:Button ID="btnUpdate" runat="server" Text="Update" OnClick="btnUpdate_Click" />

       
        <br />
        <br />
        <br />
        
        <asp:Button ID="btnRetrieveData" runat="server" Text="Retrieve Data Page" OnClick="btnRetrieveData_Click" />

    </form>
</body>
</html>
