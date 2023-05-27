# Hafta 3 Ödevi
Simpra .Net Bootcamp'i kapsamında üçüncü haftanın ödevi olarak bizden Simapi projesindeki Category ve Product modellerinin 1-M relation olacak şekilde yeniden modellememiz istendi. Bu proje Onion Architecture ve CQRS Design Pattern kullanılarak tasarlanmıştır. Projenin yapısı aşağıdaki gibidir:

![projeyapısı](https://github.com/P259-Simpra-NET-Bootcamp/aw3-hesnacaliskan/assets/56639245/16e4dfc4-3c08-48b4-9471-08254138ffc7)

# Projede Kullanınan Teknolojiler
* .Net 6
* MSSQL
* Swagger UI
* Entity Framework Code First
* Generic Repository Desing Pattern
* CQRS Design Pattern
* AutoMapper
* Onion Architecture

# Projenin Yapısı
## *Bire Çok İlişki*
İlişkisel veritabanında 3 ilişki mevcuttur, bunlar:

* Birebir ilişki (one to one)
* Bire çok ilişki (one to many)
* Çoka çok ilişki (many to many)

Bize projemizde Category-Product arasında 1-n ilişki kurmamız istendi. Bire çok ilişkileri, tek bir varlık herhangi bir sayıda diğer varlıkla ilişkilendirildiğinde kullanılır. Örneğin, bir Category ile ilişkili birçok Product olabilir, ancak her Product yalnızca bir Category ile ilişkilendirilir. Entity Framework Code First'e uyarladığımızda:

![1-n ilişki](https://github.com/P259-Simpra-NET-Bootcamp/aw3-hesnacaliskan/assets/56639245/6da0d6ba-2295-4f8c-b7ea-0f91f8f4e3ea)

## *CQRS Design Pattern*
Command ve Query sorumluluklarını ayırmamızı sağlayan bir paterndir.Projede bu şekilde uyguladım:

![CQRS](https://github.com/P259-Simpra-NET-Bootcamp/aw3-hesnacaliskan/assets/56639245/6a5f9621-f8eb-4224-8ecd-96a52f170892)
