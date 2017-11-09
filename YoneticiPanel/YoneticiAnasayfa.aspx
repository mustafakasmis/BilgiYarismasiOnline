<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="YoneticiAnasayfa.aspx.cs" Inherits="BilgiYarismasiOnline.YöneticiPanel.YöneticiAnasayfa" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">

<head runat="server">

<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>

    <title>
        YÖNETİCİ PANELİ SAYFASI
    </title>

    <style type="text/css">

        #lnkCikis{
            position:relative;
            left:1150px;
        }

    </style>

</head>

<body style="background-image:url('/images/0.jpg');">

    <h2 style="color:rgb(53, 255, 0); text-align:center;">YÖNETİCİ PANELİNE HOŞGELDİNİZ</h2>

  
    <form id="form1" runat="server">

        <asp:LinkButton ID="lnkCikis" runat="server" OnClick="lnkCikis_Click">LOG OUT</asp:LinkButton>

        <div>
            <asp:Button ID="btnSoruEklePanel" runat="server" Text="SORU EKLEME PANELİ" Font-Bold="True" Height="50px" style="margin-left: 562px; margin-top: 153px" Width="235px" OnClick="btnSoruEklePanel_Click" /><br />
            <asp:Button ID="btnSoruGuncellePanel" runat="server" Text="SORU GÜNCELLEME PANELİ" Font-Bold="True" Height="50px" style="margin-left: 539px; margin-top: 76px" Width="276px" OnClick="btnSoruGuncellePanel_Click" /><br />
            <asp:Button ID="btnSoruSilmePanel" runat="server" Text="SORU SİLME PANELİ" Font-Bold="True" Height="50px" style="margin-left: 571px; margin-top: 75px" Width="219px" OnClick="btnSoruSilmePanel_Click" />
        </div>

    </form>

</body>

</html>
