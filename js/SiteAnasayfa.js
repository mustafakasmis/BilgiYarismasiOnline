function trhKontrol() {

    var gelen = document.getElementById("kontrol").innerHTML;

    var tarih = gelen.substring(1, 5);

    var donusumtarih = parseInt(tarih);

    var gercektarih = new Date();

    if (gercektarih.getFullYear() > donusumtarih) {

        var aralik = gercektarih.getFullYear() - donusumtarih;
        donusumtarih += aralik;
        document.getElementById("kontrol").innerHTML = "&copy;" + donusumtarih + "-MUSTAFA KASMIŞ";

    }

}