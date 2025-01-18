--KULLANICI YÖNETİMİ VE VERİTABANI OLUŞTURMA

Bu proje, ASP.NET Core Web API ve Entity Framework Core kullanarak kullanıcı yönetimi ve veritabanı oluşturma işlemini gerçekleştiren bir uygulamadır. Proje, Identity ve Data Protection işlemleri ile kullanıcı kayıtlarını şifreleyerek güvenli hale getirmektedir.

--Proje Özeti:

Entity Framework Code First yaklaşımı ile User tablosu oluşturulmuştur.
Kullanıcı kayıt işlemi sırasında, şifre güvenli bir şekilde şifrelenmiştir.
Model Validation ([Required], [EmailAddress], vb.) kullanılarak kullanıcı girişi doğrulanmıştır.
Identity ve Data Protection kullanılarak, şifreleme ve kimlik doğrulama işlemleri yapılmıştır.

--Kullanılan Teknolojiler:

ASP.NET Core: Web API uygulaması oluşturmak için.
Entity Framework Core: Veritabanı işlemleri için.
Identity: Kullanıcı yönetimi ve kimlik doğrulama için.
SQL Server (LocalDB): Veritabanı yönetimi.
