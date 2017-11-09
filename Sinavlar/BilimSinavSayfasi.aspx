<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="BilimSinavSayfasi.aspx.cs" Inherits="BilgiYarismasiOnline.Sınavlar.BilimSinavSayfasi" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">

<head runat="server">

<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>

    <title>BİLİM SINAV SAYFASI</title>

    <style type="text/css">

        #lblSure{
            color:#006600;
            position:relative;
            left:1000px;
        }

        #lblCevapKontrol{
            color:#006600;
            position:relative;
            top:25px;
            left:880px;
        }

    </style>

</head>

<body style="background-image:url('/images/0.jpg');">

    <h2 style="color:rgb(53, 255, 0); text-align:center;">BİLİM SINAV SAYFASI</h2>

  

    <form id="form1" runat="server">

        <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>

        <div style="margin-top: 7px">

            <asp:Panel ID="pnlsinav" runat="server" Height="423px" style="margin-top: 0px">

                <<asp:TextBox ID="soru" runat="server" Height="167px" style="margin-left: 499px; margin-top: 82px;" TextMode="MultiLine" MaxLength="200" Width="360px"></asp:TextBox>
                   
                        <br />
                        <br />
                        <br />
                        <br />
                        <br />
                        <asp:Button ID="btnSecenekA" runat="server" Height="29px" style="margin-left: 276px" Text="" Width="152px" OnClick="btnSecenekA_Click" />
                        <asp:Button ID="btnSecenekB" runat="server" Height="29px" style="margin-left: 70px" Text="" Width="152px" OnClick="btnSecenekB_Click" />
                        <asp:Button ID="btnSecenekC" runat="server" Height="29px" style="margin-left: 99px" Text="" Width="152px" OnClick="btnSecenekC_Click" />
                        <asp:Button ID="btnSecenekD" runat="server" Height="29px" style="margin-left: 64px; margin-top: 0px;" Text="" Width="152px" OnClick="btnSecenekD_Click" />
                        
                        <br />
                        <br />
                        <br />
                        <br />

               <asp:Button ID="btnSecenekOncSoru" runat="server" Text="ÖNCEKİ SORU" style="margin-left: 448px" Font-Bold="True" Height="29px" Width="152px" Font-Italic="True" OnClick="btnSecenekOncSoru_Click" />
                        <asp:Button ID="btnSecenekSnrSoru" runat="server" Text="SONRAKİ SORU" style="margin-left: 147px" Font-Bold="True" Height="29px" Width="152px" Font-Italic="True" OnClick="btnSecenekSnrSoru_Click" />
            </asp:Panel>


           <asp:Panel ID="pnlSinavIslem" runat="server" style="margin-top: 32px" Height="90px">

                <asp:Button ID="btnSinaviBitir" runat="server" Text="SINAVI BİTİR" Font-Bold="True" Font-Italic="False" style="margin-left: 450px; margin-top: 16px" Height="37px" Width="140px" OnClick="btnSinaviBitir_Click" />
                <asp:Button ID="btnSinavdanCik" runat="server" Text="SINAVDAN ÇIK" Font-Bold="True" Font-Italic="False" style="margin-left: 171px; margin-top: 63px" Height="37px" Width="140px" OnClick="btnSinavdanCik_Click" />
               
            </asp:Panel>

        </div>

    </form>

</body>

</html>
