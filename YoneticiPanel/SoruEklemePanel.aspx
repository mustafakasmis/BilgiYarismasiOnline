<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="SoruEklemePanel.aspx.cs" Inherits="BilgiYarismasiOnline.YöneticiPanel.SoruEklemePanel" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">

<head runat="server">

<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>

    <title>SORU EKLEME SAYFASI</title>

</head>

<body style="background-image:url('/images/0.jpg');">

    <h3 style="color:#0066CC; text-align:center;">SORU EKLEME PANELİ</h3>

    <form id="form1" runat="server">

        <div>

            <asp:Panel ID="pnlSoruEkleme" runat="server" Height="506px" style="margin-left: 488px; margin-top: 38px" Width="453px">              

                <asp:Label ID="lblSoru" runat="server" Text="SORUYU GİRİNİZ" ForeColor="#0066CC"></asp:Label>
                <asp:TextBox ID="txbSoru" runat="server" Height="94px" style="margin-left: 57px; margin-top: 25px" TextMode="MultiLine" Width="198px"></asp:TextBox>
                
                <br />

                <asp:Label ID="lblSecenekA" runat="server" Text="SEÇENEK A YI GİRİNİZ" ForeColor="#0066CC"></asp:Label>
                <asp:TextBox ID="txbSecenekA" runat="server" style="margin-left: 28px; margin-top: 42px" Width="177px"></asp:TextBox>
                
                <br />

                <asp:Label ID="lblSecenekB" runat="server" Text="SECENEK B Yİ GİRİNİZ" ForeColor="#0066CC"></asp:Label>
                <asp:TextBox ID="txbSecenekB" runat="server" style="margin-left: 29px; margin-top: 37px" Width="177px"></asp:TextBox>
                
                <br />

                <asp:Label ID="lblSecenekC" runat="server" Text="SECENEK C Yİ GİRİNİZ" ForeColor="#0066CC"></asp:Label>
                <asp:TextBox ID="txbSecenekC" runat="server" style="margin-left: 28px; margin-top: 45px" Width="177px"></asp:TextBox>
                
                <br />

                <asp:Label ID="lblSecenekD" runat="server" Text="SECENEK D Yİ GİRİNİZ" ForeColor="#0066CC"></asp:Label>
                <asp:TextBox ID="txbSecenekD" runat="server" style="margin-left: 29px; margin-top: 39px" Width="177px"></asp:TextBox>
                
                <br />
                <br />
                <br />

                <asp:Label ID="lblDogruSecenek" runat="server" Text="DOĞRU SEÇENEĞİ SEÇİNİZ" ForeColor="#0066CC"></asp:Label>
                <asp:DropDownList ID="drpSecenekler" runat="server" style="margin-left: 56px">
                    <asp:ListItem>SEÇENEK A</asp:ListItem>
                    <asp:ListItem>SEÇENEK B</asp:ListItem>
                    <asp:ListItem>SEÇENEK C</asp:ListItem>
                    <asp:ListItem>SEÇENEK D</asp:ListItem>
                </asp:DropDownList>
                
                <br />
                <br />

                <asp:Label ID="lblKategoriSec" runat="server" Text="SORU KATEGORİSİNİ SEÇİNİZ" ForeColor="#0066CC"></asp:Label>
                <asp:DropDownList ID="drpKategoriSec" runat="server" style="margin-left: 46px">
                    <asp:ListItem>TARİH</asp:ListItem>
                    <asp:ListItem>BİLİM</asp:ListItem>
                    <asp:ListItem>SPOR</asp:ListItem>
                    
                </asp:DropDownList>
                
                <br />
                <br />

                <asp:Button ID="btnSoruEkle" runat="server" Text="SORU EKLE" Font-Bold="True" Height="32px" style="margin-left: 19px; margin-top: 31px" Width="119px" OnClick="btnSoruEkle_Click" />
                <asp:Button ID="btnSoruEkleIptal" runat="server" Text="SORU EKLEME İPTAL" Font-Bold="True" Height="32px" style="margin-left: 61px" Width="180px" OnClick="btnSoruEkleIptal_Click" />

            </asp:Panel>

        </div>

    </form>

</body>

</html>
