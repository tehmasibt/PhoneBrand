// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");


using ORM.Phone.DAL;
using ORM.Phone.Details;

DataContext dataContext = new();





//var remove= dataContext.Brands.FirstOrDefault(a => a.Id == 1);
//dataContext.Brands.Remove(remove);
//dataContext.SaveChanges();


//dataContext.Brands.Add(new() { Name = "Iphone", PhoneNumber = "077-777-77-77" });
//dataContext.SaveChanges();


//dataContext.Brands.AddRange
//    (
//    new() { Name = "Xiaomi", PhoneNumber = "055-555-55-55" },
//    new() { Name = "Samsung", PhoneNumber = "060-666-66-66" }
//    );
//dataContext.SaveChanges();



//BrandDetail brandDetail = new();
//var hamsi= brandDetail.Get();
//foreach (var item in hamsi)
//{
//    Console.WriteLine(item);
//}


//BrandDetail brandDetail = new();
//Console.WriteLine(brandDetail.GetOne(2));


BrandDetail brandDetail = new BrandDetail();








