﻿using BlazorEcommerce.Shared;

namespace BlazorEcommerce.Server.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ProductVariant>().HasKey(
                p => new { p.ProductId, p.ProductTypeId });

            modelBuilder.Entity<ProductType>().HasData(
                new ProductType { Id = 1, Name = "Default" },
                new ProductType { Id = 2, Name = "Paperback" },
                new ProductType { Id = 3, Name = "E-Book" },
                new ProductType { Id = 4, Name = "Audiobook" },
                new ProductType { Id = 5, Name = "Stream" },
                new ProductType { Id = 6, Name = "Blu-ray" },
                new ProductType { Id = 7, Name = "VHS" },
                new ProductType { Id = 8, Name = "PC" },
                new ProductType { Id = 9, Name = "PlayStation" },
                new ProductType { Id = 10, Name = "Xbox" }
                );


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

                    CategoryId = 1
                },
                new Product
                {
                    Id = 2,
                    Title = "三国演义",
                    Description = "《三国演义》（又名《三国志演义》《三国志通俗演义》 [45-46]）是元末明初小说家罗贯中根据陈寿《三国志》和裴松之注解以及民间三国故事传说经过艺术加工创作而成的长篇章回体历史演义小说，与《西游记》《水浒传》《红楼梦》并称为中国古典四大名著。",
                    ImageUrl = "https://p3.itc.cn/q_70/images03/20201125/148f3f1283fd450fae713ff0ace1da28.jpeg",

                    CategoryId = 1
                },
                new Product
                {
                    Id = 3,
                    Title = "西游记",
                    Description = "《西游记》是中国古代第一部浪漫主义章回体长篇神魔小说。 [39] [41]今见最早的《西游记》版本是明代万历二十年金陵世德堂《新刻出像官板大字西游记》，未署作者姓名。 [63]鲁迅、董作宾等人根据《淮安府志》“吴承恩《西游记》”的记载予以最终论定“吴承恩原著”",
                    ImageUrl = "https://p3.toutiaoimg.com/origin/pgc-image/848125d1bc50415e819487ba54b46439",

                    CategoryId = 1
                },
                new Product
                {
                    Id = 4,
                    Title = "第一滴血",
                    Description = "《第一滴血》是由特德·科特切夫执导，西尔维斯特·史泰龙、理查德·克里纳、布莱恩·丹内利、大卫·卡罗素联合主演的动作片。影片于1982年10月22日在美国上映。该片讲述了退伍军人兰博在小镇上屡受警长的欺凌，逼得他逃入山林，被迫对警察展开反击的故事。",
                    ImageUrl = "/Images/lanbo.jpg",

                    CategoryId = 2
                },
                new Product
                {
                    Id = 5,
                    Title = "终结者",
                    Description = "《终结者》是美国著名科幻电影系列，著名电影杂志《电影周刊》在评选20世纪最值得收藏的一部电影时，此片以最高票数位居第一。这部电影居然是一部早在20世纪末就拍摄完毕的科幻片，这在电脑特效技术已经相当完善的2017年可谓一大新闻。但这部电影的冠军地位决非浪得虚名，这与它所表现出的强烈的美国式个人英雄主义风格和出色的电影平衡性和完美特效是分不开的。",
                    ImageUrl = "/Images/zjz.jpg",

                    CategoryId = 2
                },
                new Product
                {
                    Id = 6,
                    Title = "弱点",
                    Description = "《弱点》是根据迈克尔·路易斯的小说《弱点：比赛进程》改编，由约翰·李·汉柯克执导，桑德拉·布洛克、蒂姆·麦格罗、昆顿·亚伦等主演的励志电影。影片讲述了一个无家可归的非洲裔男孩迈克尔·奥赫从小就是一个孤儿，一再的从领养家庭中逃走后终于遇上了好心的陶西太太，而在后者的帮助下，迈克尔·奥赫逐渐的找到了自我，在自己的身体条件与刻苦锻炼下，他终于成为了美国国家橄榄球联盟的首批被选球员",
                    ImageUrl = "/Images/ruodian.jpg",

                    CategoryId = 2
                },
                new Product
                {
                    Id = 7,
                    Title = "007",
                    Description = "《007》是风靡全球的一系列谍战片，007不仅是影片的名称，更是主人公特工詹姆斯·邦德的代号。詹姆斯·邦德（英语：James Bond）是一套小说和系列电影的主角名称。小说原作者是英国作家、前MI6特工伊恩·弗莱明。第一部007电影于1962年10月5日公映后，007电影系列风靡全球，历经六十余年长盛不衰。",
                    ImageUrl = "/Images/007.jpg",

                    CategoryId = 2
                },
                new Product
                {
                    Id = 8,
                    Title = "拳皇97",
                    Description = "《拳皇97》是由日本SNK公司于1997年发行的一款街机格斗游戏，为《拳皇96》的续作，其后续作品为《拳皇98》。该作相比拳皇系列前三个版本在各方面均有较大改进，是拳皇系列的成熟之作。《拳皇97》是“大蛇篇”三部曲中的最后一章，讲述了各路决斗家组成队伍参加拳皇大赛，卷入八杰集复活大蛇的阴谋，并最终为这场因缘之战画上休止符。《拳皇97》在全国各地街机厅长盛不衰，并衍生各种非官方修改版本。其中流传较广的版本有《拳皇97风云再起》，其修改方向主要有全部隐藏角色可选，能量槽不会消耗等要素。",
                    ImageUrl = "/Images/quanhuang.jpg",

                    CategoryId = 3
                },
                new Product
                {
                    Id = 9,
                    Title = "魂斗罗",
                    Description = "该游戏的故事背景是根据著名恐怖片《异形（Alien）》改编。1987年第一款魂斗罗诞生在名为Jamma的街机上。此外KONAMI于1989年还在日式计算机MSX2上推出了大型游戏机的同名移植版。",
                    ImageUrl = "/Images/hundouluo.jpg",

                    CategoryId = 3
                },
                new Product
                {
                    Id = 10,
                    Title = "超级马里奥",
                    Description = "《超级马力欧》游戏系列由任天堂公司出品。任天堂是日本著名的游戏制作公司，其制作的游戏及主机、掌机系列在全球范围内深受欢迎。",
                    ImageUrl = "/Images/mali.jpg",

                    CategoryId = 3
                }
                );

            modelBuilder.Entity<ProductVariant>().HasData(
                new ProductVariant { ProductId = 1, ProductTypeId = 2, Price = 9.99m, OriginalPrice = 19.99m },
                new ProductVariant { ProductId = 2, ProductTypeId = 2, Price = 3.99m, OriginalPrice = 9.99m },
                new ProductVariant { ProductId = 3, ProductTypeId = 2, Price = 9.99m, OriginalPrice = 14.99m },
                new ProductVariant { ProductId = 4, ProductTypeId = 6, Price = 4.99m, OriginalPrice = 9.99m },
                new ProductVariant { ProductId = 5, ProductTypeId = 6, Price = 5.99m, OriginalPrice = 9.99m },
                new ProductVariant { ProductId = 6, ProductTypeId = 6, Price = 19.99m, OriginalPrice = 39.99m },
                new ProductVariant { ProductId = 7, ProductTypeId = 6, Price = 12.99m, OriginalPrice = 15.99m },
                new ProductVariant { ProductId = 8, ProductTypeId = 10, Price = 10.99m, OriginalPrice = 12 },
                new ProductVariant { ProductId = 9, ProductTypeId = 10, Price = 39.99m, OriginalPrice = 43.99m },
                new ProductVariant { ProductId = 10, ProductTypeId = 10, Price = 29.99m, OriginalPrice = 39.99m }
                );
        }

        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }

        public DbSet<ProductType> ProductTypes { get; set; }
        public DbSet<ProductVariant> ProductVariants { get; set; }

    }
}
