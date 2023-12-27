﻿namespace BlazorEcommerce.Server.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>().HasData(
                new Category
                {
                    Id = 1,
                    Name = "Books",
                    Url = "books"
                },
                new Category
                {
                    Id = 2,
                    Name = "Movies",
                    Url = "movies"
                },
                new Category
                {
                    Id = 3,
                    Name = "Video Games",
                    Url = "video-games"
                }
                );



            // 向数据表中插入数据
            modelBuilder.Entity<Product>().HasData(
                new Product
                {
                    Id = 1,
                    Title = "儒林外史",
                    Description = "《儒林外史》是清代吴敬梓创作的长篇小说，成书于乾隆十四年（1749年）或稍前，现以抄本传世，初刻于嘉庆八年（1803年）。全书五十六回，以写实主义描绘各类人士对于“功名富贵”的不同表现，一方面真实地揭示人性被腐蚀的过程和原因，从而对当时吏治的腐败、科举的弊端、礼教的虚伪等进行了深刻的批判和嘲讽；一方面热情地歌颂了少数人物以坚持自我的方式所作的对于人性的守护，从而寄寓了作者的理想。小说白话的运用已趋纯熟自如，人物性格的刻画也颇为深入细腻，尤其是采用高超的讽刺手法，使该书成为中国古典讽刺文学的佳作。《儒林外史》代表着中国古代讽刺小说的高峰，它开创了以小说直接评价现实生活的范例。 《儒林外史》脱稿后即有手抄本传世，后人评价甚高，鲁迅认为该书思想内容“秉持公心，指摘时弊”，胡适认为其艺术特色堪称“精工提炼”。在国际汉学界，该书更是影响颇大，早有英、法、德、俄、日、西班牙等多种文字传世，并获汉学界盛赞，有认为《儒林外史》足堪跻身于世界文学杰作之林，可与薄伽丘、塞万提斯、巴尔扎克或狄更斯等人的作品相提并论，是对世界文学的卓越贡献。",
                    ImageUrl = "/Images/1.jpg",
                    Price = 9.99m,
                    CategoryId = 1
                },
                new Product
                {
                    Id = 2,
                    Title = "三国演义",
                    Description = "《三国演义》（又名《三国志演义》《三国志通俗演义》 [45-46]）是元末明初小说家罗贯中根据陈寿《三国志》和裴松之注解以及民间三国故事传说经过艺术加工创作而成的长篇章回体历史演义小说，与《西游记》《水浒传》《红楼梦》并称为中国古典四大名著。",
                    ImageUrl = "https://p3.itc.cn/q_70/images03/20201125/148f3f1283fd450fae713ff0ace1da28.jpeg",
                    Price = 7.99m,
                    CategoryId = 1
                },
                new Product
                {
                    Id = 3,
                    Title = "西游记",
                    Description = "《西游记》是中国古代第一部浪漫主义章回体长篇神魔小说。 [39] [41]今见最早的《西游记》版本是明代万历二十年金陵世德堂《新刻出像官板大字西游记》，未署作者姓名。 [63]鲁迅、董作宾等人根据《淮安府志》“吴承恩《西游记》”的记载予以最终论定“吴承恩原著”",
                    ImageUrl = "https://p3.toutiaoimg.com/origin/pgc-image/848125d1bc50415e819487ba54b46439",
                    Price = 6.99m,
                    CategoryId = 1
                }
                );
        }

        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }

    }
}
