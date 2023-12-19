### C1 - Etki alaný katmaný oluþturuldu.
* Etki alaný katmaný oluþturuldu. 
* Varlýklarda ortak olan özellikler için BaseEntity sýnýfý tanýmlandý.
* Projede kullanýlacak entityler belirlendi ve tanýmlandý.

### C2 - Uygulama katmaný oluþturuldu.
* DTO'lar oluþturuldu.
* Arayüzler tanýmlandý.
* Gerekli klasörler oluþturuldu.
* Etki alaný katmanýnda isim güncellemeleri yapýldý.

### C3 - Ýsim güncellemeleri yapýldý.
* Arayüzler async olacak þekilde düzenlendi. 
* Arayüzler bir IGenericRepository arayüzüne baðlandý.
* Etki alaný katmanýnda isim güncellemeleri yapýldý.

### C4 - Persistence katmaný oluþturuldu.
* Depo arayüzlerinin tanýmý bu katmanda yapýldý.
* Application katmanýndaki IActivityRepository arayüzündeki namespace katmaný düzeltildi.
* DbContext sýnýfý oluþturuldu. Domain katmanýnda tanýmlanan entityler üzerinden DbSet'ler tanýmlandý.
* Tüm projedeki gereksiz namespace kullanýmý kaldýrýldý.

### C5 - WebApi katmaný oluþturuldu.
* Migration ile Db oluþturuldu.
* Pet controller eklendi. 
* DB'ye örnek veri eklendi.

### C6 - DB güncellendi.
* Db migration ile güncellendi.
* MediatR projeye dahil edildi. 
* Kontrolcülerden varlýklara doðrudan eriþim mediatr ile kaldýrýldý.

### C7 - Application katmanýnda düzenleme yapýldý.
* Features kalsör düzeni deðiþtirildi.
* Mapping profile kalsörü kaldýrýldý. Yerine tüm entity'lerin kendisine ait mapping profilleri oluþturuldu.
* Mediatr sürümleri 11.x'den 9.0'a çekildi.

### C8 - Evcil hayvan ekleme özelliði eklendi.
* Evcil hayvan ekleme özelliði eklendi. 
* Veriler endpoint'de DTO ile alýnýp CommandHandler tarafýnda eksik bilgiler tamamlanarak veri tabanýna kaydedilmesi saðlandý.

### C9 - Evcil hayvan sorgulamarý düzenlendi.

### C10 - Entity'lerde ve DB'de düzenlemeler yapýldý.
* Entity'ler düzenlendi.
* DTO'lar düzenlenmek üzere kaldýrýldý.
* ServiceRegistration'lar IServicesCollection döndürecek þekilde düzenlendi.
* Kontrolcüler düzenlenmek üzere kaldýrýlý.

### C11 - Ýþlem kayýtlarý entity'leri oluþturuldu.
* Yapýlan iþlemlerin kayýtlarýnýn DB'de tutulmasý için gerekli entity'ler oluþturuldu ve DB'ye migration ile yansýtýldý.
* Kayýt entity'ler için Repository arayüzleri oluþturuldu.
* Entity'ler için Repository arayüzleri oluþturuldu.
* Infrastructure katmaný içinde Presistence içerisinde oluþturulan Repository'lerin içerisi dolduruldu.
* Geçerli katmanýn ServiceRegistraction fonksiyonu düzenlendi.
