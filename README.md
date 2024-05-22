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

## Template Method Design Pattern
Basit ama etkili bir tasarım kalıbı olan Template method design pattern, davranışsal design pattern grubunda yer alır.
Template Method, akışın(ya da algoritmanın) ana iskeletini kendi elinde tutup detayların geliştirilmesini alt sınıflara bırakır.
Kabaca bir abstact class ve buna bağlı bir ya da birden fazla concrete classtan oluşur.
Abstract class template class dediğimiz akışın adımlarını ve sıralamasını belirleyen classtır.
Concrete classlar ise bu akıştaki detayları barındıran classlardır.

Bir örnek ile devam edelim. Örneğimizde bir alışveriş sepetimiz olsun ve bu alışveriş sepetine attığımız ürünlerin ödeme süreci olsun. Bu ödeme süreci genel akış olarak tüm ürünler için aynı olmakla birlikte ürün bazında bazı stepleri farklılık gösterebilir olacaktır ki bu da tam olarak template design pattern kullanmamız gereken senaryodur. Televizyon ve buzdolabi olan iki ürünümüzün satın alma süreci ; başlangıç, ürün seçimi, ödeme ve bitiş olmak üzere her ürün için genel geçer 4 stepten oluşsun ve başlangıç ve bitiş tüm ürünler için ortak iken ürün seçimi ve ödeme şekli stepleri üründen ürüne farklılık göstersin.

## Observer Design Pattern
Observer Design Patter, aralarında one-to-many ilişki bulunan ve nesneler arası bağımlılıkların söz konusu olduğu durumlarda, bağımlı nesnelerin bağlı olunan nesnenin durumuna göre güncellenebilmesi/haberdar olabilmesi amacı ile kullanılır. Bu durumda bağımlı olunan(takip edilen, abone olunan) nesne Subject; bağımlı olan(abone) nesne ise Observer olarak isimlendirilir. Davranışsal(Behavioral) tasarım desenlerinden biridir ve kullanılması ile birlikte performans düşüşünün engellenmesi, hata yapma riskinin azaltılması gibi avantajlar elde edilir.

Observer adından da anlaşılacağı üzere gözlemci, izleyici, gözcü yahut gözetmen diye nitelendirilen, anlamı gibi işlev gören bir tasarım desenidir. Elimizdeki mevcut nesnenin durumunda herhangi bir değişiklik olduğunda, bu değişiklerden diğer nesneleri haberdar eden bir tasarımdan bahsediyoruz. Dahada net bir şekilde bahsetmek gerekirse, elimizdeki “x” nesnesinin “y” özelliğinde bir güncellenme, değişiklik yahut belirli bir şartın gerçekleşmesi gibi bir durum cereyan ettiğinde bu “x” nesnesini -izleyen- -gözleyen- diğer “z”, “w”, “k” vs. nesnelerine bu yeni durumu bildiren sisteme Observer tasarım deseni diyoruz.

Observer patternin klasik örnekleri arasında finans örneği gelir. Borsacılar borsadaki herhangi bir değişimden anında haberdar olmak ister. Finans kağıtlarındaki herhangi bir değişimde tüm borsacıları uyarmak mail yahut notifikasyon göndermek istiyorsak observer tasarım deseniyle finans kağıtlarını observe edip, gerekli bildirimi yapabiliriz.

## Unit Of Work Design Pattern
Unit Of Work tasarım deseni, yazılım uygulamamızda veritabanıyla ilgili her bir aksiyonun anlık olarak veritabanına yansıtılmasını engelleyen ve buna nazaran tüm aksiyonları biriktirip bir bütün olarak bir defada tek bir connection üzerinden gerçekleştirilmesini sağlayan ve böylece veritabanı maliyetlerini oldukça minimize eden bir tasarım desenidir.

Veritabanı işlemlerini toplu halde gerçekleştirmemizi sağlayan ve olası bir hata durumunda topyekün geri alınabilmesine olanak tanır.

Unit of Work tasarım deseni, Generic Repository Pattern ile uyumlu bir şekilde kullanılabilen ve faydalı bir yapıdır. Tasarım desenlerini ihtiyaçlarınıza göre kullanmak önemlidir. Özellikle veri işlemlerinin yoğun olduğu uygulamalarda, özellikle e-ticaret sitelerinde sıkça kullanılan bir desendir.

## Repository Design Pattern

Repository tasarım deseni, yazılım geliştirme süreçlerinde veri erişimini düzenlemek ve yönetmek için kullanılan bir desen olarak karşımıza çıkar. Bu desen, veri tabanıyla iletişim kurmak, veri işlemlerini gerçekleştirmek ve veri kaynaklarını yönetmek gibi işlemleri soyutlamayı hedefler.

Repository deseni, genellikle nesne tabanlı programlama (OOP) ve katmanlı mimarilerle birlikte kullanılır. Bu tasarım deseni, veritabanına erişimi merkezi bir yerde toplar ve iş mantığını veri erişim detaylarından ayırarak kodun daha temiz, düzenli ve bakımı daha kolay hale gelmesini sağlar.

Repository deseninin ana amacı, veri tabanı işlemlerini ve veri erişimini izole etmek ve soyutlamaktır. Bu, aşağıdaki avantajları sağlar:

Kodun Daha Bakımı Kolay Olması: Veri erişim kodunu merkezi bir yerde toplamak, kodun bakımını ve güncellemelerini daha kolay hale getirir. Veritabanı yapısında değişiklik yapılması gerektiğinde, sadece repository sınıflarında değişiklik yapılması yeterli olabilir.

Daha İyi Test Edilebilirlik: Repository deseni, veri erişim işlemlerini soyutladığı için, iş mantığını test etmek istediğinizde veritabanı ile ilgili detaylarla uğraşmak zorunda kalmazsınız. Bu da kodun daha iyi bir şekilde test edilmesini sağlar.

Yeniden Kullanılabilirlik: Veri erişim kodunu ayrı bir katmana yerleştirmek, aynı veri kaynaklarına farklı parçaların erişebilmesini sağlar ve böylece kodun yeniden kullanılabilirliğini artırır.

Repository desenini kullanarak, veri erişim kodu ve iş mantığı ayrılabilir. Genellikle bir arayüz veya soyut sınıf tanımlanır ve bu arayüzü veya soyut sınıfı gerçek veri kaynağına erişimi sağlayan sınıflar (örneğin, veritabanı sınıfları) uygular. Bu sayede, iş mantığı veri erişim detaylarından izole edilmiş olur.
