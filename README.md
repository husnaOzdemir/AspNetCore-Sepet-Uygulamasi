# 🛒 ASP.NET Core MVC Sepet Uygulaması

Bu proje, ASP.NET Core MVC kullanılarak geliştirilmiş temel bir alışveriş sepeti uygulamasıdır.

Projede kullanıcıların ürünleri görüntüleyebilmesi, sepete ekleyebilmesi ve sepetten silebilmesi için session tabanlı bir yapı kullanılmıştır.

---

# 🚀 Proje Amacı

Bu projenin amacı:

- ASP.NET Core MVC mimarisini uygulamalı olarak kullanmak
- Controller, Model ve View yapısını öğrenmek
- Session yönetimi ile temel sepet sistemi geliştirmek
- Web uygulamalarında veri akışını yönetmek

olarak belirlenmiştir.

---

# 🧩 Proje Özellikleri

✅ Ürün listeleme sistemi  
✅ Sepete ürün ekleme  
✅ Sepetten ürün silme  
✅ Session tabanlı sepet yönetimi  
✅ MVC mimarisi kullanımı  
✅ Controller - Model - View yapısı  
✅ Razor View kullanımı  
✅ Dependency Injection yapısı  

---

# 🛠️ Kullanılan Teknolojiler

| Teknoloji | Kullanım Amacı |
|---|---|
| C# | Ana programlama dili |
| ASP.NET Core MVC | Web uygulaması geliştirme |
| Razor View Engine | Arayüz yapısı |
| Session | Sepet bilgisi saklama |
| .NET 8 | Uygulama altyapısı |
| Visual Studio | Geliştirme ortamı |

---

# 📂 Proje Yapısı

```text
AspNetCore-Sepet-Uygulamasi
│
├── Controllers/
│   ├── CartController.cs
│   ├── ProductsController.cs
│   └── HomeController.cs
│
├── Models/
│   └── Product.cs
│
├── Views/
│   ├── Cart/
│   ├── Products/
│   └── Shared/
│
├── Data/
│   ├── IDatabase.cs
│   ├── XDatabase.cs
│   └── YDatabase.cs
│
├── wwwroot/
├── Program.cs
└── WebApplication10.csproj
```

---

# 🛒 Sepet Sistemi

Projede kullanıcıların ürünleri sepete ekleyebilmesi için session yapısı kullanılmıştır.

Sepet işlemleri:

- ürün ekleme
- ürün silme
- sepet görüntüleme

işlemlerini kapsamaktadır.

---

# 📦 Ürün Yönetimi

Ürünler örnek veri yapıları üzerinden listelenmektedir.

Kullanıcılar ürünleri görüntüleyebilir ve istedikleri ürünleri sepete ekleyebilir.

---

# ⭐ Not

Bu proje eğitim amacıyla geliştirilmiş temel seviyede bir ASP.NET Core MVC uygulamasıdır.
