<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="listings.aspx.cs" Inherits="EmployeeInfo.listings" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
  <title>Listings</title>
  <link rel="stylesheet" href="https://cdn.jsdelivr.net/npm/bootswatch@5.3.2/dist/superhero/bootstrap.min.css">


</head>
<body>
  <form id="form1" runat="server">
    <div>
      <h1>Micro Listings</h1>
      <p>SKUs</p>
      <div>
        <asp:Button ID="btnSaveAddSkus" runat="server" OnClick="btnSaveAddSkus_Click" Text="Save/Add&gt;&gt;" style="text-align: right" />
      </div>
      <div>
        <p>
          <asp:TextBox ID="txtSkusPasted" runat="server" Height="150px" Width="150px" TextMode="MultiLine" Wrap="False" BackColor="Yellow"></asp:TextBox>
          &nbsp;
     
        <asp:ListBox ID="listboxSkusEdit" runat="server" Height="154px" Width="165px" BackColor="#FF66FF"></asp:ListBox>

          <asp:Label ID="lblCount" runat="server"></asp:Label>

        </p>
      </div>

      <p>
        <asp:Button ID="btnEditSkus" runat="server" Text="Edit Skus" Width="81px" OnClick="btnEditSkus_Click" />


      </p>

      <p>
        <asp:TreeView ID="tree1" runat="server" ShowLines="True" Width="217px">
        </asp:TreeView>
        &nbsp;
      </p>
    </div>
  </form>
</body>
</html>
