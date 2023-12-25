using Joker.LearnBlazor.WebService.Models;

namespace Joker.LearnBlazor.WebService.Repository
{
    public interface ICategory
    {
        List<Category> GetTreeModel();

        List<Category> GetList();

        List<string> GetMBXList(int caid);

        Category GetModel(int caid);

        void Add(Category model);
        void Delete(int id);
        void Update(Category modle); 

    }
}
