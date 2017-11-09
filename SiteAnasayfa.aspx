<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="SiteAnasayfa.aspx.cs" Inherits="BilgiYarismasiOnline.SiteAnasayfa" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">

<head runat="server">

<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>

    <title>ONLİNE BİLGİ YARIŞMASI ANASAYFA</title>

    <link href="css/Anasayfa.css" rel="stylesheet" type="text/css"/>
    <script src="js/SiteAnasayfa.js"></script>
  
</head>

<body style="background-image:url('images/0.jpg');" onload="trhKontrol()">

    <form id="form1" runat="server">

        <div>

            <h2>ONLİNE BİLGİ YARIŞMASI SİSTEMİ</h2><br />

            <asp:LinkButton ID="LnkBtnAnasayfa" runat="server" OnClick="LnkBtnAnasayfa_Click" >ANASAYFA</asp:LinkButton>
               
            <asp:LinkButton ID="LnkBtnHakkimizda" runat="server" OnClick="LnkBtnHakkimizda_Click" >HAKKIMIZDA</asp:LinkButton>
            
            <asp:LinkButton ID="LnkBtnIletisim" runat="server" OnClick="LnkBtnIletisim_Click">İLETİŞİM</asp:LinkButton>
             
        </div>

        <div id="dv1">
            
            <h3>GİRİŞ PANELİ</h3>

            <asp:Label ID="lblKulAdi" runat="server" ForeColor="#FFFF66" Text="KULLANICI ADI"></asp:Label>
            <asp:TextBox ID="txbKulAdi" MaxLength="10" runat="server" style="margin-left: 41px; margin-top: 35px" Width="208px"></asp:TextBox>
            
            <asp:Label ID="lblSifre" runat="server" ForeColor="#FFFF66" Text="PAROLA"></asp:Label>
            <asp:TextBox ID="txbParola" MaxLength="10" runat="server" style="margin-left: 97px; margin-top: 23px" Width="207px" TextMode="Password"></asp:TextBox><br />

            <asp:Button ID="btnGiris" runat="server" Text="GİRİŞ YAP" Height="27px" style="margin-left: 169px; margin-top: 29px" Width="98px" Font-Bold="True" OnClick="btnGiris_Click" /><br />
            <asp:Button ID="btnKayitOl" runat="server" Text="KAYIT OL" Font-Bold="True" Height="27px" style="margin-left: 169px; margin-top: 18px" Width="98px" OnClick="btnKayitOl_Click" />
            
        </div>

     </form>

     <footer id="trh"><b id="kontrol">&copy;2017-MUSTAFA KASMIŞ</b></footer>

</body>

</html>