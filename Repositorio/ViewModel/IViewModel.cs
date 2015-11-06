using System.Security.Cryptography.X509Certificates;

namespace Repositorio.ViewModel
{
    public interface IViewModel<TModel> where TModel : class
    {

        TModel ToBaseDatos();

        void FromBaseDatos(TModel model);

        void UpdateBaseDatos(TModel model);

        object[] GetKeys();
    }
}