<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="YarismaKategorileri.aspx.cs" Inherits="BilgiYarismasiOnline.YarismaKategorileri" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">

<head runat="server">

<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    
    <title>YARIŞMA KATEGORİLERİ SAYFASI</title>

    <link href="css/Kategoriler.css" type="text/css" rel="stylesheet"/>

</head>

<body>
    
    <h1 style="color:red; text-align:center; font-family:'Times New Roman', Times, serif; font-size:22pt;">YARIŞMA KATEGORİLERİ</h1>

    <form id="form1" runat="server">
        
        <div margin-top: 43px;">

            <asp:ImageButton ID="ImgBtnTarih" runat="server" Title="TARİH KATEGORİSİ" Height="161px" ImageUrl="~/images/tarih.jpg" style="margin-left: 350px; margin-top: 81px" Width="217px" OnClick="ImgBtnTarih_Click" />
            <asp:ImageButton ID="ImgBtnBilim" runat="server" Title="BİLİM KATEGORİSİ" Height="161px" ImageUrl="~/images/bilim.jpg" style="margin-left: 221px; margin-top: 8px" Width="217px" OnClick="ImgBtnBilim_Click" />
            <asp:ImageButton ID="ImgBtnSpor" runat="server" Title="SPOR KATEGORİSİ" Height="161px" ImageUrl="~/images/spor.jpg" style="margin-left: 577px; margin-top: 83px;" Width="217px" OnClick="ImgBtnSpor_Click" />
            
        </div>
    
    </form>

</body>

</html>
