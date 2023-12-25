using Joker.LearnBlazor.Web.Models;

namespace Joker.LearnBlazor.Web.Repository
{
    public interface ICategory
    {
        List<Category> GetTreeModel();

        List<Category> GetList();

        List<string> GetMBXList(int caid);

        Category GetModel(int caid);

    }
}
