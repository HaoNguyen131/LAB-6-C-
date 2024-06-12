using System;
using System.Collections.Generic;
using System.Linq;

public class PhoneLab6
{
    public int id { get; set; }
    public int shop_id { get; set; }
    public string name { get; set; }
    public int price { get; set; }
    public string des { get; set; }

    public PhoneLab6(int id, int shop_id, string name, int price, string des)
    {
        this.id = id;
        this.shop_id = shop_id;
        this.name = name;
        this.price = price;
        this.des = des;
    }
}

public class ShopLab6
{
    public int id { get; set; }
    public string name { get; set; }
    public string address { get; set; }

    public ShopLab6(int id, string name, string address)
    {
        this.id = id;
        this.name = name;
        this.address = address;
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        // Khởi tạo danh sách Shop
        List<ShopLab6> listShop = new List<ShopLab6>()
        {
            new ShopLab6(1, "HCM", "Quận 12"),
            new ShopLab6(2, "Hà Nội", "Quận Nam Từ Liêm"),
            new ShopLab6(3, "Đà Nẵng", "Quận Hải Châu")
        };

        // Khởi tạo danh sách Phone
        List<PhoneLab6> listPhone = new List<PhoneLab6>()
        {
            new PhoneLab6(1, 1, "IP 15", 100, "độc lạ bình dương"),
            new PhoneLab6(2, 2, "IP 16", 1000, "độc lạ bình dương"),
            new PhoneLab6(3, 3, "IP 17", 10000, "độc lạ bình dương"),
            new PhoneLab6(4, 1, "IP 18", 100000, "độc lạ bình dương")
        };

        // b) Sử dụng Group Join viết chương trình để được kết quả xuất ra màn hình như sau:
        var resultB = listShop.GroupJoin(listPhone,
            shop => shop.id,
            phone => phone.shop_id,
            (shop, phones) => new
            {
                ShopName = shop.name,
                Phones = phones.Select(phone => new { PhoneName = phone.name, PhonePrice = phone.price })
            });

        foreach (var item in resultB)
        {
            Console.WriteLine($"ShopName: {item.ShopName}");
            foreach (var phone in item.Phones)
            {
                Console.WriteLine($"  phoneName: {phone.PhoneName}, phonePrice: {phone.PhonePrice}");
            }
        }
    }
}