using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TsukiStore.Models;

namespace TsukiStore.Data
{
    public class AppDbInitializer
    {
        public static void Seed(IApplicationBuilder applicationBuilder)
        {
            using (var serviceScope = applicationBuilder.ApplicationServices.CreateScope())
            {
                var context = serviceScope.ServiceProvider.GetService<AppDbContext>();
                context.Database.EnsureCreated();

                //Product
                if (!context.Products.Any())
                {
                    context.Products.AddRange(new List<Product>()
                    {
                        new Product()
                        {
                            Назва = "Корм для котів Gourmet Gold Savoury Cake Beef & Tomatoes",
                            Клас = "Преміум",
                            Вага = "85г",
                            Опис = "Ваш кіт",
                            Ціна = 26,
                            ImageURL = "https://masterzoo.ua/content/images/2/1800x1800l80mc0/vlazhnyy-korm-dlya-koshek-gourmet-gold-savoury-cake-beef-tomatoes-85-g-govyadina-i-tomaty-20921667411015.webp",
                            Вид = ProductType.Вологий
                        },
                    });

                    context.SaveChanges();
                }
                //Brand
                if (!context.Brands.Any())
                {
                    context.Brands.AddRange(new List<Brand>()
                    {
                    new Brand()
                    {
                        Назва = "Gourmet",
                        ProfilePictureURL = "https://www.nestle.com/sites/default/files/gourmet-logo-round.png",
                        Опис = "Багато років вчені в усьому світі займалися пошуком способів продовження життя домашнім вихованцям. Дослідження показали, що головну роль в цьому відіграє якісна їжа. Тому виробник Gourmet компанія Nestle Purina Petcare розробила лінійку кормів, адаптовану до потреб чотирилапих друзів. Це вологе харчування різних видів, щоб можна було вибрати відповідне вихованцю."
                    },

                    new Brand()
                    {
                        Назва = "Brit",
                        ProfilePictureURL = "https://img.toba.ua/brands/7_brit.jpg",
                        Опис = "'Сузір'я' - приватна сімейна компанія, яка була заснована в 1992 році. Починаючи як оптово-роздрібна, протягом декількох років компанія освоїла виробництво зернових сумішей, акваріумів та аксесуарів. У 1995 році компанія почала імпорт зоотоварів і поступово збільшила портфоліо представлених брендів."
                    },

                    new Brand()
                    {
                        Назва = "Optimeal",
                        ProfilePictureURL = "https://zooera.com.ua/image/cache/catalog/%D0%91%D1%80%D0%B5%D0%BD%D0%B4%D1%8B/optimeal-2-375x375.png",
                        Опис = "OptiMeal – супепреміальне харчування для котів і собак, яке розроблено під контролем ветеринарів. Унікальна рецептура для здоров’я та краси домашнього улюбленця складається із добірних м’ясних інгредієнтів, натурального антиоксиданту, пребіотиків, ягід, корисних трав. Все це створює щоденний природний захист імунітету кота чи собаки."
                    },
                    new Brand()
                    {
                        Назва = "Royal Canin",
                        ProfilePictureURL = "https://cdn.freebiesupply.com/logos/thumbs/2x/royal-canin-1-logo.png",
                        Опис = "Бренд Royal Canin є власністю корпорації MARS. Це гігант ринку кормів для тварин, репутація якого підтверджена позитивним іміджем торгових марок KiteKat, Whiskas, Chappi, Pedigree. В розробці рецептури приймають участь ветеринари та дієтологи з 48 країн."
                    },
                });

                    context.SaveChanges();
                }
                //Brand & Product
                if (!context.Brands_Products.Any())
                {
                    context.Brands_Products.AddRange(new List<Brand_Product>()
                    {
                        new Brand_Product()
                        {
                            BrandId = 1,
                            ProductId = 1
                        },
                    });
                    context.SaveChanges();
                }
            }
        }
    }
}
