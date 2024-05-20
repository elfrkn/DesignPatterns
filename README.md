# DesignPatterns #

## Chain of Responsibility
Sorumluluk Zinciri, istekleri bir işleyici zinciri boyunca aktarmamıza olanak tanıyan davranışsal bir tasarım modelidir. Bir istek alındığında, her işleyici ya isteği işlemeye ya da zincirdeki bir sonraki işleyiciye iletmeye karar verir.</br>
Bir örnek ile ele alacak olursak; veznede çalışan bir kişi için günlük nakit para çekim miktarı 40 bin TL olan bir banka düşünelim ve bu bankaya gelen bir müşteri veznede bulunan kişiden 240 bin TL para çekmek istediğini söyledi. Banka kuralları gereği bu işlemin sırasıyla veznedar, yönetici, müdür ve bölge sorumlusu tarafından sırasıyla onaylaması gerekmekte. Bakacak olduğumuzda zincir şeklinde birbirine bağlı olan bir onay yapısı bulunmakta. 

Akış olarak özetleyecek olursak;

 1-Müşteri 480 bin TL lik para çekme isteğini veznedar'a iletir.</br>
 2-Veznedar bu isteği alır ve kontrol eder eğer onaylayabileceği bir tutar ise onaylar, onaylayabileceği bir tutar değilse yöneticisine gönderir.</br>
 3-Yönetici isteği alır  onaylayabileceği bir tutar değilse müdüre iletir.</br>
 4-Müdür kontrol eder eğer onaylayabileceği bir tutar değilse bölge sorumlusunun onayına gönderir.</br>
 5-Bölge sorumlusu onaylar ve para müşteriye verilir.

## CQRS Design Pattern
CQRS, ana odağı write (yazma) ve read (okuma) sorumluluklarının ayrıştırılmasına dayanan bir mimari tasarım modelidir. 
Uygulamalarınızda CQRS mimari modeline göre oluşturursanız; uygulamanızın performansını, ölçeklenebilirliğini ve güvenliğini en üst düzeye çıkarabilirsiniz.

Bu yaklaşımda metotlar 2 farklı modele ayrılmalıdır:

-<b> Commands:</b> Objenin veya sistemin durumunu değiştirir.Yeni bir veri eklemek ya da var olan veri üzerinde güncelleme yapmak için kullanılır. Örnek vermek gerekirse; Insert, Update, Delete. Geriye veri döndürmez. </br>
-<b> Queries: </b> Sadece sonucu geriye döner herhangi bir objenin veya sistemin durumunu değiştirmez.Veritabanından veri almak için kullanılır. Geriye sadece belirtilen modeli döner ve veri üzerinde herhangi bir değişiklik yapmaz.

#### CQRS Ne Zaman Kullanılmalı ?
<li>Birbirinden ayrı sistemlerde olası bir servisin hata vermesi durumunda bu hatanın sistemin akışına olumsuz yönde etkisi olmuyorsa kullanılabilir.</li>
<li>Kompleks iş kurallarının olabileceği veya iş kurallarının sık sık değiştiği yapılarda kullanılabilir.</li>
<li>Yüksek veri trafiğinin olduğu sistemlerde kullanılabilir.</li>

## Template Method Desaign Pattern
Basit ama etkili bir tasarım kalıbı olan Template method design pattern, davranışsal design pattern grubunda yer alır.
Template Method, akışın(ya da algoritmanın) ana iskeletini kendi elinde tutup detayların geliştirilmesini alt sınıflara bırakır.
Kabaca bir abstact class ve buna bağlı bir ya da birden fazla concrete classtan oluşur.
Abstract class template class dediğimiz akışın adımlarını ve sıralamasını belirleyen classtır.
Concrete classlar ise bu akıştaki detayları barındıran classlardır.
