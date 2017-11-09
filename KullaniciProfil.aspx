<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="KullaniciProfil.aspx.cs" Inherits="BilgiYarismasiOnline.KullaniciProfil" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">

<head runat="server">

<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>

    <title>
        KULLANICI PROFİL SAYFASI
    </title>

    <link href="css/KullaniciProfil.css" type="text/css" rel="stylesheet" />

</head>

<body style="background-image:url('images/0.jpg');">

    <h2>KULLANICI PROFİL SAYFASI</h2>

    <form id="form1" runat="server">
            
        <div id="dv1">

            <br />

            <asp:Label ID="lblAd" runat="server" Text="ADINIZ" ForeColor="#FFFF66"></asp:Label>&nbsp;
            <asp:TextBox ID="txbAd" runat="server" MaxLength="15" style="margin-left: 58px" Width="239px"></asp:TextBox>
            <br />
            <br />

            <asp:Label ID="lblSoyad" runat="server" Text="SOYADINIZ" ForeColor="#FFFF66"></asp:Label>&nbsp;
            <asp:TextBox ID="txbSoyad" runat="server" MaxLength="15" style="margin-left: 28px" Width="240px"></asp:TextBox>
            <br />
            <br />

            <asp:Label ID="lblKulAdi" runat="server" Text="KULLANICI ADINIZ" ForeColor="#FFFF66"></asp:Label>&nbsp;
            <asp:TextBox ID="txbKulAdi" runat="server" MaxLength="10" Width="207px"></asp:TextBox>
            <br />
            <br />

            <asp:Label ID="lblEmail" runat="server" Text="E_MAİL ADRESİNİZ" ForeColor="#FFFF66"></asp:Label>&nbsp;
            <asp:TextBox ID="txbEmail" runat="server" MaxLength="45" Width="206px"></asp:TextBox>
            <br />
            <br />

            <asp:Label ID="lblParola" runat="server" Text="PAROLANIZ" ForeColor="#FFFF66"></asp:Label>&nbsp;
            <asp:TextBox ID="txbParola" runat="server" MaxLength="10" TextMode="Password" style="margin-left: 24px" Width="241px"></asp:TextBox>
            <br />
            <br />

            <asp:Label ID="lblEnsevilen" runat="server" Text="SEVDİĞİNİZ KATEGORİ" Font-Bold="False" ForeColor="#FFFF66"></asp:Label>&nbsp;
            <asp:DropDownList ID="drpKategoriler" runat="server" style="margin-left: 34px">
                <asp:ListItem>TARİH</asp:ListItem>
                <asp:ListItem>SPOR</asp:ListItem>
                <asp:ListItem>BİLİM</asp:ListItem>
                <asp:ListItem>SANAT</asp:ListItem>                
            </asp:DropDownList><br />
            
            <br />
            <br />

            <asp:Button ID="btnProfilGnc" runat="server" Text="PROFİLİMİ GÜNCELLE" Font-Bold="True" Height="31px" OnClick="btnProfilGnc_Click" />
            <asp:Button ID="btnProfilGncIptal" runat="server" Text="PROFİL GÜNCELLEME İPTAL" Font-Bold="True" Height="31px" OnClick="btnProfilGncIptal_Click" />
            
        </div>


    </form>

</body>

</html>
