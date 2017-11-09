,<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="SiteIletisim.aspx.cs" Inherits="BilgiYarismasiOnline.SiteIletisim" %>

<!DOCTYPE html><html xmlns="http://www.w3.org/1999/xhtml"><head runat="server"><meta http-equiv="Content-Type" content="text/html; charset=utf-8"/><title>İLETİŞİM SAYFASI</title><link  href="css/Iletisim.css" type="text/css" rel="stylesheet" /></head><body style="background-image:url('images/0.jpg')"><h2>İLETİŞİM</h2>

    <form id="form1" runat="server">
       
        <div style="margin-top: 11px">

            <asp:Panel ID="Panel1" runat="server" style="margin-left: 0px; margin-top: 5px;" Width="391px">

                <asp:Label ID="lblAd" runat="server" Text="ADINIZ" ForeColor="#FFFF99"></asp:Label>&nbsp;&nbsp;
                <asp:TextBox ID="txbAd" runat="server" Width="213px" style="margin-left: 93px"></asp:TextBox><br />
               
                <br />

                <asp:Label ID="lblSoyad" runat="server" Text="SOYADINIZ" ForeColor="#FFFF66"></asp:Label>&nbsp;&nbsp;
                <asp:TextBox ID="txbSoyad" runat="server" Width="214px" style="margin-left: 62px"></asp:TextBox><br />

                <br />

                <asp:Label ID="lblKulAdi" runat="server" Text="KULLANICI ADINIZ" ForeColor="#FFFF66"></asp:Label>&nbsp;&nbsp;
                <asp:TextBox ID="txbKulAdi" runat="server" Width="213px" style="margin-left: 2px"></asp:TextBox><br />

                <br />

                <asp:Label ID="lblMail" runat="server" Text="E-MAİLİNİZ" ForeColor="#FFFF66"></asp:Label>&nbsp;&nbsp;
                <asp:TextBox ID="txbMail" runat="server" Width="213px" style="margin-left: 60px"></asp:TextBox><br />
                
                <br />

                <asp:Label ID="lblMesaj" runat="server" Text="MESAJINIZ" ForeColor="#FFFF66"></asp:Label><br /><br />
                <asp:TextBox ID="txbMesaj" runat="server" Height="153px" Width="372px" style="margin-left: 2px" TextMode="MultiLine"></asp:TextBox><br />

                <br />

                <asp:Label ID="lblKontrol" runat="server" ForeColor="#FFFF66"></asp:Label>&nbsp;&nbsp;
                <asp:TextBox ID="txbKontrol" runat="server" style="margin-left: 10px" Width="215px"></asp:TextBox><br />

                <br />
                
                <asp:Button ID="mailGonder" runat="server" Text="GÖNDER" style="margin-left: 157px; margin-top: 12px" Font-Bold="True" OnClick="mailGonder_Click" />

                <h3 style="color:rgb(53, 255, 0); text-align:center;">BÜTÜN ALANLARIN DOLDURULMASI ZORUNLUDUR</h3>

            </asp:Panel>
       
        </div>

    </form>

</body>

</html>
