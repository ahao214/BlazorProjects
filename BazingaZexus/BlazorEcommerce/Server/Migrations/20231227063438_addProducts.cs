using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BlazorEcommerce.Server.Migrations
{
    public partial class addProducts : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CategoryId", "Description", "ImageUrl", "Price", "Title" },
                values: new object[,]
                {
                    { 4, 2, "《第一滴血》是由特德·科特切夫执导，西尔维斯特·史泰龙、理查德·克里纳、布莱恩·丹内利、大卫·卡罗素联合主演的动作片。影片于1982年10月22日在美国上映。该片讲述了退伍军人兰博在小镇上屡受警长的欺凌，逼得他逃入山林，被迫对警察展开反击的故事。", "/Images/lanbo.jpg", 3.99m, "第一滴血" },
                    { 5, 2, "《终结者》是美国著名科幻电影系列，著名电影杂志《电影周刊》在评选20世纪最值得收藏的一部电影时，此片以最高票数位居第一。这部电影居然是一部早在20世纪末就拍摄完毕的科幻片，这在电脑特效技术已经相当完善的2017年可谓一大新闻。但这部电影的冠军地位决非浪得虚名，这与它所表现出的强烈的美国式个人英雄主义风格和出色的电影平衡性和完美特效是分不开的。", "/Images/zjz.jpg", 10.99m, "终结者" },
                    { 6, 2, "《弱点》是根据迈克尔·路易斯的小说《弱点：比赛进程》改编，由约翰·李·汉柯克执导，桑德拉·布洛克、蒂姆·麦格罗、昆顿·亚伦等主演的励志电影。影片讲述了一个无家可归的非洲裔男孩迈克尔·奥赫从小就是一个孤儿，一再的从领养家庭中逃走后终于遇上了好心的陶西太太，而在后者的帮助下，迈克尔·奥赫逐渐的找到了自我，在自己的身体条件与刻苦锻炼下，他终于成为了美国国家橄榄球联盟的首批被选球员", "/Images/ruodian.jpg", 3.69m, "弱点" },
                    { 7, 2, "《007》是风靡全球的一系列谍战片，007不仅是影片的名称，更是主人公特工詹姆斯·邦德的代号。詹姆斯·邦德（英语：James Bond）是一套小说和系列电影的主角名称。小说原作者是英国作家、前MI6特工伊恩·弗莱明。第一部007电影于1962年10月5日公映后，007电影系列风靡全球，历经六十余年长盛不衰。", "/Images/007.jpg", 13.99m, "007" },
                    { 8, 3, "《拳皇97》是由日本SNK公司于1997年发行的一款街机格斗游戏，为《拳皇96》的续作，其后续作品为《拳皇98》。该作相比拳皇系列前三个版本在各方面均有较大改进，是拳皇系列的成熟之作。《拳皇97》是“大蛇篇”三部曲中的最后一章，讲述了各路决斗家组成队伍参加拳皇大赛，卷入八杰集复活大蛇的阴谋，并最终为这场因缘之战画上休止符。《拳皇97》在全国各地街机厅长盛不衰，并衍生各种非官方修改版本。其中流传较广的版本有《拳皇97风云再起》，其修改方向主要有全部隐藏角色可选，能量槽不会消耗等要素。", "/Images/quanhuang.jpg", 30.99m, "拳皇97" },
                    { 9, 3, "该游戏的故事背景是根据著名恐怖片《异形（Alien）》改编。1987年第一款魂斗罗诞生在名为Jamma的街机上。此外KONAMI于1989年还在日式计算机MSX2上推出了大型游戏机的同名移植版。", "/Images/hundouluo.jpg", 20.99m, "魂斗罗" },
                    { 10, 3, "《超级马力欧》游戏系列由任天堂公司出品。任天堂是日本著名的游戏制作公司，其制作的游戏及主机、掌机系列在全球范围内深受欢迎。", "/Images/mali.jpg", 15.99m, "超级马里奥" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10);
        }
    }
}
