<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="KullaniciIstatistik.aspx.cs" Inherits="BilgiYarismasiOnline.LiderlerTablosu" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">

<head runat="server">

<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>

    <title>KULLANICI İSTATİSTİK SAYFASI</title>

    <link href="css/KullaniciIstatistik.css" type="text/css" rel="stylesheet"/>

</head>

<body style="background-image:url('images/0.jpg'); width: 791px; margin-left: 293px;">

    <h2 style="color:red; text-align:center;">KULLANICI İSTATİSTİKLERİ </h2>
    <form id="form1" runat="server">

        <div style="border-style: inherit; border-width: inherit; border-color: aqua; margin-left: 0px; margin-top: 243px;">

            <asp:Label ID="lblTarih" runat="server" Text="TARİH İSTATİSTİK "></asp:Label>

            &nbsp;
            <asp:Literal ID="Literal1" runat="server">Doğru Sayısı</asp:Literal>

            <asp:TextBox ID="txbTarihDogru" runat="server" style="margin-left: 29px" Width="110px"></asp:TextBox>

            &nbsp;

             <asp:Literal ID="Literal2" runat="server">Yanlış Sayısı</asp:Literal>

            <asp:TextBox ID="txbTarihYanlis" runat="server" style="margin-left: 42px"></asp:TextBox>

            <hr style="color:red;" />


            <asp:Label ID="lblSpor" runat="server" Text="SPOR İSTATİSTİK"></asp:Label>
            &nbsp;
            <asp:Literal ID="Literal3" runat="server">Doğru Sayısı</asp:Literal>

            <asp:TextBox ID="txbSporDogru" runat="server" style="margin-left: 40px" Width="106px"></asp:TextBox>
            &nbsp;
            <asp:Literal ID="Literal4" runat="server">Yanlış Sayısı</asp:Literal>

            <asp:TextBox ID="txbSporYanlis" runat="server" style="margin-left: 47px"></asp:TextBox>

            <hr  style="color:red;"/>

            <asp:Label ID="lblBilim" runat="server" Text="BİLİM İSTATİSTİK "></asp:Label>

            &nbsp;
            <asp:Literal ID="Literal5" runat="server">Doğru Sayısı</asp:Literal>

            <asp:TextBox ID="txbBilimDogru" runat="server" style="margin-left: 38px" Width="110px"></asp:TextBox>

            &nbsp;

             <asp:Literal ID="Literal6" runat="server">Yanlış Sayısı</asp:Literal>

            <asp:TextBox ID="txbBilimYanlis" runat="server" style="margin-left: 42px"></asp:TextBox>

            <hr style="color:red;" />


        </div>

    </form>

</body>

</html>
