# SaleDataExample

Gerçekleşen satışın kargo durumunu sorgulayabileceğimiz
restful servis geliştirmenizi bekliyoruz.

#1. Satış (Sale)
http://5e209e06e31c6e0014c60962.mockapi.io/api/sales/3
Bu servisten satışa ait ürün bilgisini alabilirsiniz.
2. Ürün (Product)
http://5e209e06e31c6e0014c60962.mockapi.io/api/products/47
Satış uygulamasından aldığınız "productId" ile bu servisi çağırabilir,
ürün detaylarına ulaşabilirsiniz.
3. Kargo (Shipping)
http://5e209e06e31c6e0014c60962.mockapi.io/api/shipping/3
Bu servisten ilgili satışın kargo durumunu öğrenebilirsiniz.
Status: false (Teslim edilmedi)
Status: true (Teslim edildi)

Örnek Request : /sale/shipping?id=X

Response:
{
 "status": "TESLİM EDİLDİ",
 "sale": {
 "id": 3,
 "code": "bf610641-da64-4153-ad34-0aadf7a993e1"
 },
 "product": {
 "id": 1,
 "name": "Tasty Frozen Keyboard",
 "price": 150.00
 }
}
