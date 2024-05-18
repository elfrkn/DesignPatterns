# DesignPatterns #

## Chain of Responsibility
Sorumluluk Zinciri, istekleri bir işleyici zinciri boyunca aktarmamıza olanak tanıyan davranışsal bir tasarım modelidir. Bir istek alındığında, her işleyici ya isteği işlemeye ya da zincirdeki bir sonraki işleyiciye iletmeye karar verir.
Bir örnek ile ele alacak olursak; veznede çalışan bir kişi için günlük nakit para çekim miktarı 40 bin TL olan bir banka düşünelim ve bu bankaya gelen bir müşteri veznede bulunan kişiden 240 bin TL para çekmek istediğini söyledi. Banka kuralları gereği bu işlemin sırasıyla veznedar, yönetici, müdür ve bölge sorumlusu tarafından sırasıyla onaylaması gerekmekte. Bakacak olduğumuzda zincir şeklinde birbirine bağlı olan bir onay yapısı bulunmakta. 

Akış olarak özetleyecek olursak;

 1-Müşteri 480 bin TL lik para çekme isteğini veznedar'a iletir.
 2-Veznedar bu isteği alır ve kontrol eder eğer onaylayabileceği bir tutar ise onaylar, onaylayabileceği bir tutar değilse yöneticisine gönderir,
 3-Yönetici isteği alır  onaylayabileceği bir tutar değilse müdüre iletir,
 4-Müdür kontrol eder eğer onaylayabileceği bir tutar değilse bölge sorumlusunun onayına gönderir,
 5-Bölge sorumlusu onaylar ve para müşteriye verilir.