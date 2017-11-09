<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="SoruSilmePanel.aspx.cs" Inherits="BilgiYarismasiOnline.YöneticiPanel.SoruSilmePanel" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">

<head runat="server">

<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>

    <title>SORU SİLME SAYFASI</title>

</head>

<body style="background-image:url('/images/0.jpg');">

    <form id="form1" runat="server">

            <asp:GridView ID="grdSorular" runat="server" OnSelectedIndexChanged="grdSorular_SelectedIndexChanged" AutoGenerateColumns="False" BackColor="White" BorderColor="White" BorderStyle="Ridge" BorderWidth="2px" CellPadding="3" CellSpacing="1" DataKeyNames="id" DataSourceID="SqlDataSource1" GridLines="None" style="margin-left: 243px; margin-top: 199px;" >
                <Columns>
                    <asp:BoundField DataField="id" HeaderText="id" InsertVisible="False" ReadOnly="True" SortExpression="id"></asp:BoundField>
                    <asp:BoundField DataField="kategori_adi" HeaderText="kategori_adi" SortExpression="kategori_adi"></asp:BoundField>
                    <asp:BoundField DataField="soru" HeaderText="soru" SortExpression="soru"></asp:BoundField>
                    <asp:BoundField DataField="secenekA" HeaderText="secenekA" SortExpression="secenekA"></asp:BoundField>
                    <asp:BoundField DataField="secenekB" HeaderText="secenekB" SortExpression="secenekB"></asp:BoundField>
                    <asp:BoundField DataField="secenekC" HeaderText="secenekC" SortExpression="secenekC"></asp:BoundField>
                    <asp:BoundField DataField="secenekD" HeaderText="secenekD" SortExpression="secenekD"></asp:BoundField>
                    <asp:ButtonField CommandName="Delete" Text="Sil" />
                </Columns>
                <FooterStyle BackColor="#C6C3C6" ForeColor="Black" />
                <HeaderStyle BackColor="#4A3C8C" Font-Bold="True" ForeColor="#E7E7FF" />
                <PagerStyle BackColor="#C6C3C6" ForeColor="Black" HorizontalAlign="Right" />
                <RowStyle BackColor="#DEDFDE" ForeColor="Black" />
                <SelectedRowStyle BackColor="#9471DE" Font-Bold="True" ForeColor="White" />
                <SortedAscendingCellStyle BackColor="#F1F1F1" />
                <SortedAscendingHeaderStyle BackColor="#594B9C" />
                <SortedDescendingCellStyle BackColor="#CAC9C9" />
                <SortedDescendingHeaderStyle BackColor="#33276A" />
            </asp:GridView>

            <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:OnlineBilgiYarismasiConnectionString %>" SelectCommand="select soruBilgi.id,kategoriler.kategori_adi,soru,secenekA,secenekB,secenekC,secenekD from soruBilgi inner join kategoriler on soruBilgi.kategori_id=kategoriler.id;"></asp:SqlDataSource>

    </form>

</body>

</html>
