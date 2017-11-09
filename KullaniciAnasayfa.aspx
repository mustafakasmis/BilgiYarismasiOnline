<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="KullaniciAnasayfa.aspx.cs" Inherits="BilgiYarismasiOnline.KullaniciAnasayfa" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">

<head runat="server">

<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>

    <title>KULLANICI ANASAYFA</title>

    <link  href="css/KullaniciAnasayfaStil.css" type="text/css" rel="stylesheet"/>

</head>
    
<body style="background-image:url('images/0.jpg')">

    <form id="form1" runat="server">

        <div>

    <asp:LinkButton ID="LnkAnasayfa" runat="server" OnClick="LnkAnasayfa_Click" Title="BU SAYFAYA YÖNLENDİRİLİRSİNİZ">ANASAYFA</asp:LinkButton>
    <asp:LinkButton ID="LnkProfil" runat="server" OnClick="LnkProfil_Click" Title="BU SAYFAYA YÖNLENDİRİLİRSİNİZ">PROFİL</asp:LinkButton>
    <asp:LinkButton ID="LnkKategori" runat="server" OnClick="LnkKategori_Click" Title="BU SAYFAYA YÖNLENDİRİLİRSİNİZ">YARIŞMA KATEGORİLERİ</asp:LinkButton>
    <asp:LinkButton ID="LnkLiderlerTbl" runat="server"  OnClick="LnkLiderlerTbl_Click" Title="BU SAYFAYA YÖNLENDİRİLİRSİNİZ">İSTATİSTİK</asp:LinkButton>
    <asp:LinkButton ID="LnkKurallar" runat="server" OnClick="LnkKurallar_Click" Title="BU SAYFAYA YÖNLENDİRİLİRSİNİZ">YARIŞMA KURALLARI</asp:LinkButton>

            <asp:LinkButton ID="LnkCikis" runat="server" OnClick="LnkCikis_Click">LOG OUT</asp:LinkButton>

            <br />

            <asp:Panel ID="pnlBilim" runat="server" style="margin-right: 0px; margin-top: 18px;" Visible="False" ForeColor="#66FF66">
                
                <h2 style="text-align:center;">BİLİM NEDİR</h2>

<h4>Bilim, evrenin veya olayların bir bölümünü konu olarak seçen, deneye dayanan yöntemler ve gerçeklikten yararlanarak sonuç çıkarmaya çalışan bilgi edinme ve yöntemli araştırma sürecine denir.
Bilimin asıl uğraşı alanı doğa olaylarıdır. Burada doğa olaylarını en genel kapsamıyla algılıyoruz. Yalnızca fiziksel olguları değil, sosyolojik, psikolojik, ekonomik, kültürel vb. bilgi alanlarının hepsi doğa olaylarıdır.
Özetle, insanla ve çevresiyle ilgili olan her olgu bir doğa olayıdır.
</h4>
               
            </asp:Panel>


            <asp:Panel ID="pnlSpor" runat="server" Visible="False" ForeColor="#66FF33">

                <h2 style="text-align:center;">SPOR NEDİR</h2>

<h4>Vücut ve kafa yetileri eğitimiyle birlikte eğlence de sağlayan işlerdir. 
Avcılık, atıcılık, binicilik, denizcilik, atletizm, basketbol, futbol, güreş, kayak, tenis, voleybol, yelken, kürek sporun çeşitli kollarıdır.
Spor, eski Yunanistan'da gelişmeye başladı. O çağ eğitiminde geniş yeri olan spora büyük önem verilirdi. 
Dört yılda bir düzenlenen «Olimpiyat Oyunları» nda gençler birbirleriyle yarışırlardı. 
Eski Roma'da spora verilen önem sadece gençleri savaşa hazırlamaktı. 
Ortaçağ'da da aynı amaç güdülürdü. Ancak soylu kimselerin çocukları binicilik, kılıç ve av sporu yaparlardı.</h4>
                
            </asp:Panel>

            <asp:Panel ID="pnlTarih" runat="server" Visible="False" ForeColor="#66FF33" style="margin-top: 3px">

                <h2 style="text-align:center;">TARİH NEDİR</h2>

<h4>Tarih, insan topluluklarının sosyal, ekonomik, kültürel, siyasi, dini ilişkilerini, birbiriyle olan münasebetlerini, belgelere dayanarak, yer ve zaman göstererek inceleyen , olayların sebep ve sonuç ilişkilerini açıklayan bilim dalıdır.

*Tarihi Olayların Özelliği:

Belgelere dayanma
Yer-zaman ve sebep-sonuç ilişkisi.
Deney ve gözlem yapılamaz.
Tekrarlanamaz.
Olayın meydana geldiği ortam önemlidir.
Dünü anlatır, bugünü açıklar ve geleceğe ışık tutar.
Bir tarihi olay, diğer bir tarihi olayın sebepleri ya da sonuçları arasında yer alır.</h4>  
                
            </asp:Panel>

            
           </div>

    </form>

    

</body>

</html>