# My Portfolio Project

ASP.NET Core MVC kullanılarak geliştirilmiş, SQL Server veritabanı ile çalışan dinamik kişisel portfolyo ve yönetim paneli projesidir.

Proje; kişisel bilgilerin, projelerin, yeteneklerin, iş deneyimlerinin ve iletişim bilgilerinin veritabanı üzerinden yönetilebilmesini amaçlamaktadır. Yönetim paneli aracılığıyla portfolyo içerikleri düzenlenebilir, gelen mesajlar takip edilebilir ve çeşitli istatistikler görüntülenebilir.

## 🚀 Proje Hakkında

My Portfolio Project, kişisel portfolyo sitesini dinamik bir yapıya dönüştürmek amacıyla geliştirilmiştir.

ASP.NET Core MVC mimarisi kullanılarak oluşturulan projede, kullanıcı arayüzü ile yönetim paneli birbirinden ayrılmıştır. İçeriklerin büyük bölümü SQL Server veritabanından alınarak dinamik şekilde görüntülenmektedir.

Proje kapsamında:

- Dinamik kişisel portfolyo arayüzü
- ASP.NET Core MVC mimarisi
- Entity Framework Core ile veritabanı işlemleri
- SQL Server entegrasyonu
- CRUD (Create, Read, Update, Delete) işlemleri
- Yönetim paneli
- Gelen mesajların yönetimi
- Dashboard ve istatistik ekranları
- CV oluşturma ve indirme işlemi

gibi özellikler bulunmaktadır.

## 🛠️ Kullanılan Teknolojiler

| Teknoloji | Açıklama |
|---|---|
| C# | Backend programlama dili |
| .NET 9 | Uygulama platformu |
| ASP.NET Core MVC | Web uygulaması mimarisi |
| Entity Framework Core 9 | ORM ve veritabanı işlemleri |
| Microsoft SQL Server | İlişkisel veritabanı |
| Razor View | Dinamik HTML sayfaları |
| HTML5 | Sayfa yapısı |
| CSS3 | Tasarım ve stillendirme |
| JavaScript | İstemci tarafı etkileşimleri |
| Bootstrap | Responsive arayüz bileşenleri |
| LINQ | Veritabanı sorguları |
| EF Core Migrations | Veritabanı şema yönetimi |

## 🖥️ Proje Arayüzü

### 1. Kullanıcı Arayüzü

Ziyaretçilerin kişisel bilgileri ve projeleri inceleyebildiği portfolyo sayfasıdır.

**Öne çıkan bölümler:**

- **Ana Sayfa:** Kişisel portfolyo sayfasının giriş alanı.
- **Öne Çıkan Alan (Feature):** Veritabanındaki öne çıkan başlık ve açıklamaların görüntülenmesi.
- **Hakkımda:** Kişisel tanıtım başlığı, kısa açıklama ve detaylı bilgilerin dinamik olarak gösterilmesi.
- **Portfolyo:** Veritabanına kayıtlı projelerin başlık, alt başlık, açıklama, görsel ve bağlantı bilgilerinin listelenmesi.
- **İstatistikler:** Yetenek, deneyim, proje ve referans kayıtlarının sayısal olarak görüntülenmesi.
- **İletişim:** Telefon, e-posta, adres ve iletişim açıklamalarının veritabanından alınması.
- **Footer:** Sayfanın alt alanı ve bağlantıları.

Kullanıcı arayüzünde ASP.NET Core ViewComponent yapısı kullanılarak sayfa bölümleri bağımsız bileşenlere ayrılmıştır.

### 2. Yönetim Paneli

Portfolyo içeriklerinin yönetilebildiği, veritabanı ile bağlantılı yönetim arayüzüdür.

#### Dashboard – İstatistik Paneli

Yönetim panelinin ana ekranında sistemdeki kayıtların sayısal özeti görüntülenir.

- Toplam iş deneyimi sayısı
- Toplam yetenek sayısı
- Toplam proje sayısı
- Toplam referans sayısı
- Gelen mesaj sayısı
- Okunmamış mesaj sayısı
- Sosyal medya hesabı sayısı
- Öne çıkan içerik sayısı
- Son eklenen deneyimin unvanı
 <img width="2549" height="1019" alt="image" src="https://github.com/user-attachments/assets/96e7d9bc-bcbe-4e2a-ba3a-4bf94b4ffdf0" />


İstatistikler LINQ sorguları kullanılarak SQL Server veritabanından dinamik olarak alınmaktadır.

#### Hakkımda Yönetimi

Kişisel tanıtım bilgilerinin düzenlendiği bölümdür.

- Başlık güncelleme
- Kısa açıklama düzenleme
- Detaylı hakkımda metnini güncelleme

<img width="2558" height="1037" alt="image" src="https://github.com/user-attachments/assets/7a31245e-7c33-48a2-bfec-1542c70125df" />


#### Yetenek Yönetimi

Teknik ve kişisel yeteneklerin yönetildiği bölümdür.

- Yetenekleri listeleme
- Yeni yetenek ekleme
- Yetenek güncelleme
- Yetenek silme
- Yetenek seviyesini yüzde (%) olarak belirleme

Yetenek seviyeleri yönetim panelinde progress bar üzerinden görüntülenmektedir.
<img width="2552" height="973" alt="image" src="https://github.com/user-attachments/assets/1c9287c8-761f-42ce-b943-a7f1ec0f30f3" />

#### Deneyim Yönetimi

İş ve mesleki deneyimlerin yönetildiği bölümdür.

- Deneyimleri listeleme
- Yeni deneyim ekleme
- Firma bilgisi düzenleme
- Unvan düzenleme
- Tarih bilgisi güncelleme
- Deneyim açıklaması güncelleme
- Deneyim silme
<img width="2548" height="805" alt="image" src="https://github.com/user-attachments/assets/7f197a7a-7756-4326-9e9b-d814e654a343" />


#### Portfolyo Yönetimi

Projelerin yönetildiği bölümdür.

- Projeleri listeleme
- Yeni proje ekleme
- Proje başlığını düzenleme
- Alt başlık ve açıklama güncelleme
- Proje görsel bağlantısı tanımlama
- Proje URL bağlantısı ekleme
- Proje bilgilerini güncelleme
- Proje silme

Proje görselleri ve bağlantıları veritabanında tutulan alanlar üzerinden yönetilmektedir.
<img width="2559" height="1274" alt="image" src="https://github.com/user-attachments/assets/a95975d4-50ea-4e6a-b394-f8aa080347c1" />

#### Sosyal Medya Yönetimi

Sosyal medya hesaplarının yönetildiği bölümdür.

- Sosyal medya hesaplarını listeleme
- Yeni hesap ekleme
- Platform adını düzenleme
- Profil bağlantısını güncelleme
- İkon sınıfını belirleme
- Hesap silme
<img width="2559" height="861" alt="image" src="https://github.com/user-attachments/assets/36970b66-ca81-483d-949e-a9a9a7b6c1a2" />

#### İletişim Bilgileri Yönetimi

Portfolyo sayfasında gösterilen iletişim bilgilerinin düzenlendiği bölümdür.

- İletişim başlığını güncelleme
- Açıklama düzenleme
- Birinci telefon numarası
- İkinci telefon numarası
- Birinci e-posta adresi
- İkinci e-posta adresi
- Adres bilgisi
<img width="2551" height="1130" alt="image" src="https://github.com/user-attachments/assets/32ef7246-5dde-4b03-a6c5-9bda3b9e144e" />

#### Mesaj Yönetimi

Sistemde kayıtlı mesajların takip edildiği yönetim ekranıdır.

- Gelen mesajları listeleme
- Gönderen adı ve e-posta bilgilerini görüntüleme
- Mesaj konusunu ve gönderim tarihini görüntüleme
- Mesaj detaylarını inceleme
- Mesajı okundu olarak işaretleme
- Mesajı okunmadı olarak işaretleme
- Mesaj silme
- Okunmamış mesaj sayısını görüntüleme

Mesajlar, gönderim tarihine göre yeniden eskiye sıralanmaktadır.
<img width="2559" height="1098" alt="image" src="https://github.com/user-attachments/assets/a4c40eb0-9bc2-4144-9679-498548aa53dc" />


#### Yapılacaklar Listesi (To-Do List)

Yönetim panelinde görevlerin takip edilebildiği bölümdür.

- Görev listeleme
- Yeni görev ekleme
- Görev güncelleme
- Görev silme
- Göreve tarih atama
- Görevi tamamlandı olarak işaretleme
- Tamamlanan görevi yeniden yapılmadı durumuna getirme

Tamamlanan görevler arayüzde farklı şekilde gösterilmektedir.
<img width="2558" height="1022" alt="image" src="https://github.com/user-attachments/assets/c9a7173d-5377-40ff-8e39-754976f77150" />

## 🗄️ Veritabanı Yapısı

Projede Microsoft SQL Server ve Entity Framework Core kullanılmaktadır.

Veritabanı işlemleri `MyPortfolioContext` sınıfı üzerinden gerçekleştirilmektedir.

### Veritabanı Tabloları

| Tablo | Açıklama |
|---|---|
| Abouts | Kişisel tanıtım ve hakkımda bilgileri |
| Contacts | İletişim bilgileri |
| Experiences | İş ve mesleki deneyimler |
| Features | Öne çıkan başlık ve açıklamalar |
| Messages | İletişim mesajları |
| Portfolios | Portfolyo projeleri |
| Skills | Yetenekler ve yetenek seviyeleri |
| SocialMedias | Sosyal medya hesapları |
| Testimonials | Referans bilgileri |
| ToDoLists | Yönetim paneli görevleri |

### Entity Framework Core

Veritabanı işlemlerinde Entity Framework Core kullanılmıştır.

- DbContext üzerinden veritabanı bağlantısı
- DbSet üzerinden tablo tanımlamaları
- LINQ sorguları
- Kayıt ekleme, silme ve güncelleme işlemleri
- Migration ile veritabanı şeması yönetimi

Proje içerisinde EF Core migration dosyaları da bulunmaktadır.

## 🏗️ Proje Mimarisi

Proje, ASP.NET Core MVC mimarisine uygun olarak katmanlı klasör yapısıyla düzenlenmiştir.

```text
MyPortolioProject
│
├── Controllers
│   ├── AbilitiesController.cs
│   ├── AboutController.cs
│   ├── ContactController.cs
│   ├── CvController.cs
│   ├── ExperienceController.cs
│   ├── HomeController.cs
│   ├── LayoutController.cs
│   ├── MessageController.cs
│   ├── PortfolioController.cs
│   ├── SocialMediaController.cs
│   ├── StatisticController.cs
│   └── ToDoListController.cs
│
├── DAL
│   ├── Context
│   │   └── MyPortfolioContext.cs
│   │
│   └── Entitiy
│       ├── About.cs
│       ├── Contact.cs
│       ├── Experience.cs
│       ├── Feature.cs
│       ├── Message.cs
│       ├── Portfolio.cs
│       ├── Skill.cs
│       ├── SocialMedia.cs
│       ├── Testimonial.cs
│       └── ToDoList.cs
│
├── Migrations
│
├── Models
│
├── ViewComponents
│
├── Views
│   ├── Abilities
│   ├── About
│   ├── Contact
│   ├── Default
│   ├── Experience
│   ├── Home
│   ├── Layout
│   ├── Message
│   ├── Portfolio
│   ├── SocialMedia
│   ├── Statistic
│   └── ToDoList
│
├── wwwroot
│   ├── css
│   ├── js
│   ├── images
│   └── ...
│
├── Program.cs
└── MyPortolioProject.csproj
```

### Mimari Bileşenler

- **Controllers:** HTTP isteklerini karşılar, iş akışını yönetir ve ilgili View sayfalarını döndürür.
- **DAL / Context:** Entity Framework Core üzerinden SQL Server bağlantısını ve DbSet tanımlarını içerir.
- **DAL / Entity:** Veritabanı tablolarını temsil eden sınıfları barındırır.
- **ViewComponents:** Kullanıcı arayüzündeki bağımsız ve tekrar kullanılabilir sayfa bileşenlerini oluşturur.
- **Views:** Razor kullanılarak hazırlanan kullanıcı ve yönetim paneli sayfalarını içerir.
- **Migrations:** Veritabanı şema değişikliklerini takip eder.
- **wwwroot:** CSS, JavaScript, görsel ve diğer statik dosyaları barındırır.

## 📄 CV Oluşturma

Projede `CvController` üzerinden çalışan bir CV oluşturma işlemi bulunmaktadır.

CV içeriği veritabanından alınan bilgilerle dinamik olarak hazırlanır:

- Hakkımda bilgileri
- İş deneyimleri
- Yetenekler
- Portfolyo projeleri

İçerik HTML formatında oluşturularak `cv.html` dosyası şeklinde indirilir.

## ⚙️ Kurulum

Projeyi yerel ortamınızda çalıştırmak için aşağıdaki adımları takip edebilirsiniz.

### Gereksinimler

- Visual Studio 2022 veya uyumlu bir IDE
- .NET 9 SDK
- Microsoft SQL Server
- SQL Server Management Studio (SSMS)
- Entity Framework Core Tools

### 1. Projeyi Klonlayın

```bash
git clone https://github.com/sw0rdv/MyPortolioProject.git
```

### 2. Proje Dizinine Girin

```bash
cd MyPortolioProject
```

### 3. Veritabanı Bağlantısını Yapılandırın

`DAL/Context/MyPortfolioContext.cs` dosyasında bulunan SQL Server bağlantı bilgisini kendi bilgisayarınıza göre düzenleyin.

```csharp
optionsBuilder.UseSqlServer(
    @"Server=YOUR_SERVER_NAME;Database=MyPortfolioDb;Integrated Security=True;TrustServerCertificate=True"
);
```

`YOUR_SERVER_NAME` alanına kendi SQL Server instance bilginizi yazın.

### 4. Gerekli Paketleri Yükleyin

```bash
dotnet restore
```

### 5. Veritabanını Oluşturun

Entity Framework Core migration dosyalarını kullanarak veritabanını güncelleyin:

```bash
dotnet ef database update
```

EF Core komutları için gerekli araç yüklü değilse:

```bash
dotnet tool install --global dotnet-ef
```

### 6. Projeyi Çalıştırın

```bash
dotnet run
```

Uygulama, terminalde belirtilen yerel adres üzerinden açılabilir.

## 📌 Geliştirme Notları

- Proje .NET 9 ve Entity Framework Core 9 kullanılarak geliştirilmiştir.
- Veritabanı bağlantısı mevcut kaynak kodunda `MyPortfolioContext` içerisinde yapılandırılmıştır.
- Projenin çalıştırılabilmesi için bağlantı bilgisinin yerel SQL Server ortamına göre düzenlenmesi gerekir.
- Yönetim paneli için ayrı Controller ve View yapıları bulunmaktadır.
- `Testimonials` tablosu ve referans bileşeni projede yer almaktadır; mevcut referans görünümü örnek/sabit içerik kullanmaktadır.
- Ana sayfadaki iletişim alanının form arayüzü bulunmaktadır; ancak mevcut kaynak kodunda form gönderimini `Messages` tablosuna kaydeden bir POST işlemi bulunmamaktadır.
- CV çıktısı mevcut uygulamada PDF değil, HTML formatındadır.

## 👨‍💻 Geliştirici

**Özgür Nuri Vural**

Software Engineer

- GitHub: [github.com/sw0rdv](https://github.com/sw0rdv)
- LinkedIn: [LinkedIn Profilim](https://www.linkedin.com/)

---

⭐ Projeyi beğendiyseniz GitHub üzerinden yıldız vererek destek olabilirsiniz.
